namespace WebCam_20170731
{
    partial class dataLogging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataLogging));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vdoCapture = new System.Windows.Forms.PictureBox();
            this.tempChrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStrtCapt = new System.Windows.Forms.Button();
            this.lblDvcSel = new System.Windows.Forms.Label();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.temp1txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.vdoCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(12, 461);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // vdoCapture
            // 
            this.vdoCapture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("vdoCapture.ErrorImage")));
            this.vdoCapture.InitialImage = ((System.Drawing.Image)(resources.GetObject("vdoCapture.InitialImage")));
            this.vdoCapture.Location = new System.Drawing.Point(12, 69);
            this.vdoCapture.Name = "vdoCapture";
            this.vdoCapture.Size = new System.Drawing.Size(390, 202);
            this.vdoCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.vdoCapture.TabIndex = 1;
            this.vdoCapture.TabStop = false;
            // 
            // tempChrt
            // 
            this.tempChrt.BackColor = System.Drawing.Color.Gray;
            this.tempChrt.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.tempChrt.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.tempChrt.Legends.Add(legend2);
            this.tempChrt.Location = new System.Drawing.Point(408, 32);
            this.tempChrt.Name = "tempChrt";
            this.tempChrt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "TEMPERATURE";
            series2.ToolTip = "#LABEL";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.tempChrt.Series.Add(series2);
            this.tempChrt.Size = new System.Drawing.Size(726, 336);
            this.tempChrt.TabIndex = 2;
            this.tempChrt.Text = "chart1";
            // 
            // btnStrtCapt
            // 
            this.btnStrtCapt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStrtCapt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStrtCapt.BackgroundImage")));
            this.btnStrtCapt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStrtCapt.Location = new System.Drawing.Point(12, 510);
            this.btnStrtCapt.Name = "btnStrtCapt";
            this.btnStrtCapt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStrtCapt.Size = new System.Drawing.Size(114, 110);
            this.btnStrtCapt.TabIndex = 3;
            this.btnStrtCapt.UseVisualStyleBackColor = false;
            this.btnStrtCapt.Click += new System.EventHandler(this.btnStrtCapt_Click);
            // 
            // lblDvcSel
            // 
            this.lblDvcSel.AutoSize = true;
            this.lblDvcSel.Location = new System.Drawing.Point(9, 445);
            this.lblDvcSel.Name = "lblDvcSel";
            this.lblDvcSel.Size = new System.Drawing.Size(95, 13);
            this.lblDvcSel.TabIndex = 5;
            this.lblDvcSel.Text = "Choose a webcam";
            // 
            // imgCapture
            // 
            this.imgCapture.Location = new System.Drawing.Point(12, 277);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(180, 127);
            this.imgCapture.TabIndex = 7;
            this.imgCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapture.BackgroundImage")));
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.Location = new System.Drawing.Point(1192, 552);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(117, 111);
            this.btnCapture.TabIndex = 10;
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1162, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 17;
            // 
            // temp1txt
            // 
            this.temp1txt.Location = new System.Drawing.Point(1227, 49);
            this.temp1txt.Name = "temp1txt";
            this.temp1txt.Size = new System.Drawing.Size(51, 20);
            this.temp1txt.TabIndex = 18;
            this.temp1txt.TextChanged += new System.EventHandler(this.temp1txt_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1162, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1227, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1162, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1227, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1162, 132);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1227, 131);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(51, 20);
            this.textBox8.TabIndex = 24;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1162, 159);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 20);
            this.textBox9.TabIndex = 25;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1228, 159);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(51, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1162, 186);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(42, 20);
            this.textBox11.TabIndex = 27;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1228, 185);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(51, 20);
            this.textBox12.TabIndex = 28;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1162, 213);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(42, 20);
            this.textBox13.TabIndex = 29;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(1228, 212);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(51, 20);
            this.textBox14.TabIndex = 30;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1162, 240);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(42, 20);
            this.textBox15.TabIndex = 31;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(1228, 239);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(51, 20);
            this.textBox16.TabIndex = 32;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1162, 267);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(42, 20);
            this.textBox17.TabIndex = 33;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1228, 266);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(51, 20);
            this.textBox18.TabIndex = 34;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(1162, 294);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(42, 20);
            this.textBox19.TabIndex = 35;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(1228, 293);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(51, 20);
            this.textBox20.TabIndex = 36;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(1162, 321);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(42, 20);
            this.textBox21.TabIndex = 37;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(1228, 320);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(51, 20);
            this.textBox22.TabIndex = 38;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(1162, 348);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(42, 20);
            this.textBox23.TabIndex = 39;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(1228, 347);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(51, 20);
            this.textBox24.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1162, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1211, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Temperature ºC";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(408, 374);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(726, 43);
            this.webBrowser1.TabIndex = 12;
            this.webBrowser1.Url = new System.Uri("http://10.1.4.251/cgi-bin/moni/allch.cgi", System.UriKind.Absolute);
            // 
            // dataLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 678);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.temp1txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.imgCapture);
            this.Controls.Add(this.lblDvcSel);
            this.Controls.Add(this.btnStrtCapt);
            this.Controls.Add(this.tempChrt);
            this.Controls.Add(this.vdoCapture);
            this.Controls.Add(this.comboBox1);
            this.Name = "dataLogging";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DATA LOGGING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vdoCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox vdoCapture;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChrt;
        private System.Windows.Forms.Button btnStrtCapt;
        private System.Windows.Forms.Label lblDvcSel;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox temp1txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

