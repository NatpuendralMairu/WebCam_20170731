using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using HtmlAgilityPack;
using rtChart;
using System.Threading.Tasks;

namespace WebCam_20170731
{
    public partial class dataLogging : MetroFramework.Forms.MetroForm
    {
        #region INITIALIZING AND DEFINING VARIABLES AND CONSTANTS
        // IMAGE & VIDEO RELATED VARIABLES
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;
        // WEBSITE DATA SCRAPPING VARIABLES
        string html = "http://10.1.4.252/cgi-bin/ope/allch.cgi";    //      small DAQ  : http://10.1.4.252/cgi-bin/ope/allch.cgi
      //string html = "http://10.1.4.251/cgi-bin/moni/allch.cgi";   //      BIG DAQ    : http://10.1.4.251/cgi-bin/moni/allch.cgi  

        HtmlWeb web = new HtmlWeb();
        #endregion

        #region Update temperature in TextBox
        private void updateTextTemp()
        {
            var htmlDoc = web.Load(html);
            var nameNode = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[2]")[1].InnerText;
            string name = nameNode;
            string reading = ConvertWhitespacesToSingleSpaces(name);
            string readings = reading.Replace("&nbsp;", "");
            // Split the string "reading" into 2 different text boxes. 
            textBox1.Text = readings.Split(' ')[0];
            temp1txt.Text = readings.Split(' ')[1];
        }
        #endregion

        #region TEMPERATURE IN STRING TO DOUBLE
        private double tempInDouble()
        {
            double temperature = double.Parse(temp1txt.Text);
            return temperature;
        }
        #endregion

        #region CONVERT MULTIPLE WHITE SPACE TO SINGLE SPACE
        public static string ConvertWhitespacesToSingleSpaces(string value)
        {
            value = Regex.Replace(value, @"\s+", " ");
            return value;
        }
        #endregion

        #region //o\\ \\o// //o\\ \\o//IT START's HERE//o\\ \\o// //o\\ \\o//
        public dataLogging()
        {
            InitializeComponent();
        }
        #endregion

        #region LOGGING IMAGES INTO A FOLDER
        private void logImage()
        {
            int n = 100;
            for (int i = 0; i <= n; i++)
            {
                // Refresh Webpage
                getTempData();
                //Wait(500);

                // Update Text value in Textbox
                updateTextTemp();
                Wait(1000);

                tempInDouble();
                Wait(500);


                // Capture Image and Save
                imgCapture.Image = vdoCapture.Image;
                imgCapture.Image.Save("C:\\Users\\prajwal.nimmagadda\\Documents\\Webcam\\Screenshots\\Temp" + i + ".jpeg");
                Wait(1000);

                // Dispose Image files free memory
                imgCapture.Dispose();
                Wait(1000);
            }
        }
        #endregion

        #region REFRESH DATA ON THE WEBSITE
        private void getTempData()
        {
            try
            {
                if (webBrowser1.IsOffline)
                {
                    foreach (HtmlElement elem in webBrowser1.Document.GetElementsByTagName("input"))
                    {
                        if (elem.GetAttribute("value") == "Refresh")
                        {
                            elem.InvokeMember("click");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Refresh Exception!!");
            }
        }
        #endregion

        #region TIMER
        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }
        #endregion

        #region FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo CaptureDevice in CaptureDevices)
            {
                comboBox1.Items.Add(CaptureDevice.Name);
            }
            FinalFrame = new VideoCaptureDevice();
        }
        #endregion

        #region BUTTON CLICK TO DISPLAY WEBCAM VIDEO IN REALTIME
        private void btnStrtCapt_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
                vdoCapture.Image = null;
                vdoCapture.Invalidate();
                btnStrtCapt.BackColor = Color.Green;
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a webcam device!");
                    return;
                }
                FinalFrame = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                btnStrtCapt.BackColor = Color.Red;
            }
        }
        #endregion

        #region FUNCTION TO DISPLAY VIDEO IN THE IMAGE BOX
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            vdoCapture.Image = video;
        }
        #endregion

        #region FORM CLOSE
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning) FinalFrame.SignalToStop();
        }
        #endregion

        #region BUTTON CLICK FOR LOGGING IMAGES FROM WEBCAM AND DATA FROM D.A.Q
        public void btnCapture_Click(object sender, EventArgs e)
        {
            logImage();
        }
        #endregion

        private void temp1txt_TextChanged(object sender, EventArgs e)
        {
            kayChart tempData = new kayChart(tempChrt, 120);
            tempData.serieName = "TEMPERATURE";

            Task.Factory.StartNew(() =>
            {
                tempData.updateChart(tempInDouble, 1000);
            }
             );
        }
    }
}
