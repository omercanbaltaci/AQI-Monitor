namespace aqimonitor
{
    partial class Form1
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
            this.cityField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastUpdated = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.hkeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ruzgar = new System.Windows.Forms.Label();
            this.sicaklik = new System.Windows.Forms.Label();
            this.kukurtdioksit = new System.Windows.Forms.Label();
            this.pm25 = new System.Windows.Forms.Label();
            this.pm10 = new System.Windows.Forms.Label();
            this.basinc = new System.Windows.Forms.Label();
            this.ozon = new System.Windows.Forms.Label();
            this.azotdioksit = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.karbonmonoksit = new System.Windows.Forms.Label();
            this.dominantPol = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.goodLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.moderateLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sensitiveLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.zehirliLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.coksagliksizLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sagliksizLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityField
            // 
            this.cityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityField.Location = new System.Drawing.Point(25, 36);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(279, 31);
            this.cityField.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lastUpdated);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sourceLabel);
            this.panel1.Controls.Add(this.hkeLabel);
            this.panel1.Location = new System.Drawing.Point(25, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 160);
            this.panel1.TabIndex = 2;
            // 
            // lastUpdated
            // 
            this.lastUpdated.AutoSize = true;
            this.lastUpdated.Location = new System.Drawing.Point(269, 132);
            this.lastUpdated.Name = "lastUpdated";
            this.lastUpdated.Size = new System.Drawing.Size(35, 13);
            this.lastUpdated.TabIndex = 2;
            this.lastUpdated.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 42);
            this.panel2.TabIndex = 7;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceLabel.Location = new System.Drawing.Point(25, 130);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(41, 15);
            this.sourceLabel.TabIndex = 1;
            this.sourceLabel.Text = "label1";
            // 
            // hkeLabel
            // 
            this.hkeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hkeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hkeLabel.Location = new System.Drawing.Point(3, 0);
            this.hkeLabel.Name = "hkeLabel";
            this.hkeLabel.Size = new System.Drawing.Size(381, 121);
            this.hkeLabel.TabIndex = 0;
            this.hkeLabel.Text = "sample";
            this.hkeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cityField);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(17, 19);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 5;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(366, 238);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.Zoom = 0D;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gMapControl1);
            this.groupBox2.Location = new System.Drawing.Point(430, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 273);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ruzgar);
            this.groupBox3.Controls.Add(this.sicaklik);
            this.groupBox3.Controls.Add(this.kukurtdioksit);
            this.groupBox3.Controls.Add(this.pm25);
            this.groupBox3.Controls.Add(this.pm10);
            this.groupBox3.Controls.Add(this.basinc);
            this.groupBox3.Controls.Add(this.ozon);
            this.groupBox3.Controls.Add(this.azotdioksit);
            this.groupBox3.Controls.Add(this.humidity);
            this.groupBox3.Controls.Add(this.karbonmonoksit);
            this.groupBox3.Controls.Add(this.dominantPol);
            this.groupBox3.Location = new System.Drawing.Point(430, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 184);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Değerler";
            // 
            // ruzgar
            // 
            this.ruzgar.AutoSize = true;
            this.ruzgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ruzgar.Location = new System.Drawing.Point(217, 128);
            this.ruzgar.Name = "ruzgar";
            this.ruzgar.Size = new System.Drawing.Size(47, 15);
            this.ruzgar.TabIndex = 10;
            this.ruzgar.Text = "label1";
            // 
            // sicaklik
            // 
            this.sicaklik.AutoSize = true;
            this.sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklik.Location = new System.Drawing.Point(217, 102);
            this.sicaklik.Name = "sicaklik";
            this.sicaklik.Size = new System.Drawing.Size(47, 15);
            this.sicaklik.TabIndex = 9;
            this.sicaklik.Text = "label1";
            // 
            // kukurtdioksit
            // 
            this.kukurtdioksit.AutoSize = true;
            this.kukurtdioksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kukurtdioksit.Location = new System.Drawing.Point(217, 75);
            this.kukurtdioksit.Name = "kukurtdioksit";
            this.kukurtdioksit.Size = new System.Drawing.Size(47, 15);
            this.kukurtdioksit.TabIndex = 8;
            this.kukurtdioksit.Text = "label1";
            // 
            // pm25
            // 
            this.pm25.AutoSize = true;
            this.pm25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pm25.Location = new System.Drawing.Point(217, 47);
            this.pm25.Name = "pm25";
            this.pm25.Size = new System.Drawing.Size(47, 15);
            this.pm25.TabIndex = 7;
            this.pm25.Text = "label1";
            // 
            // pm10
            // 
            this.pm10.AutoSize = true;
            this.pm10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pm10.Location = new System.Drawing.Point(217, 19);
            this.pm10.Name = "pm10";
            this.pm10.Size = new System.Drawing.Size(47, 15);
            this.pm10.TabIndex = 6;
            this.pm10.Text = "label1";
            // 
            // basinc
            // 
            this.basinc.AutoSize = true;
            this.basinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basinc.Location = new System.Drawing.Point(6, 154);
            this.basinc.Name = "basinc";
            this.basinc.Size = new System.Drawing.Size(47, 15);
            this.basinc.TabIndex = 5;
            this.basinc.Text = "label1";
            // 
            // ozon
            // 
            this.ozon.AutoSize = true;
            this.ozon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozon.Location = new System.Drawing.Point(6, 128);
            this.ozon.Name = "ozon";
            this.ozon.Size = new System.Drawing.Size(47, 15);
            this.ozon.TabIndex = 4;
            this.ozon.Text = "label1";
            // 
            // azotdioksit
            // 
            this.azotdioksit.AutoSize = true;
            this.azotdioksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.azotdioksit.Location = new System.Drawing.Point(6, 102);
            this.azotdioksit.Name = "azotdioksit";
            this.azotdioksit.Size = new System.Drawing.Size(47, 15);
            this.azotdioksit.TabIndex = 3;
            this.azotdioksit.Text = "label1";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humidity.Location = new System.Drawing.Point(6, 75);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(47, 15);
            this.humidity.TabIndex = 2;
            this.humidity.Text = "label1";
            // 
            // karbonmonoksit
            // 
            this.karbonmonoksit.AutoSize = true;
            this.karbonmonoksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karbonmonoksit.Location = new System.Drawing.Point(6, 47);
            this.karbonmonoksit.Name = "karbonmonoksit";
            this.karbonmonoksit.Size = new System.Drawing.Size(47, 15);
            this.karbonmonoksit.TabIndex = 1;
            this.karbonmonoksit.Text = "label1";
            // 
            // dominantPol
            // 
            this.dominantPol.AutoSize = true;
            this.dominantPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dominantPol.Location = new System.Drawing.Point(5, 19);
            this.dominantPol.Name = "dominantPol";
            this.dominantPol.Size = new System.Drawing.Size(47, 15);
            this.dominantPol.TabIndex = 0;
            this.dominantPol.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.goodLabel);
            this.panel3.Location = new System.Drawing.Point(25, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 50);
            this.panel3.TabIndex = 7;
            // 
            // goodLabel
            // 
            this.goodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodLabel.Location = new System.Drawing.Point(0, 3);
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(64, 47);
            this.goodLabel.TabIndex = 0;
            this.goodLabel.Text = "label1";
            this.goodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.moderateLabel);
            this.panel4.Location = new System.Drawing.Point(89, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 50);
            this.panel4.TabIndex = 8;
            // 
            // moderateLabel
            // 
            this.moderateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.moderateLabel.Location = new System.Drawing.Point(0, 3);
            this.moderateLabel.Name = "moderateLabel";
            this.moderateLabel.Size = new System.Drawing.Size(64, 47);
            this.moderateLabel.TabIndex = 0;
            this.moderateLabel.Text = "label1";
            this.moderateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.sensitiveLabel);
            this.panel5.Location = new System.Drawing.Point(153, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 50);
            this.panel5.TabIndex = 9;
            // 
            // sensitiveLabel
            // 
            this.sensitiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sensitiveLabel.Location = new System.Drawing.Point(0, 3);
            this.sensitiveLabel.Name = "sensitiveLabel";
            this.sensitiveLabel.Size = new System.Drawing.Size(64, 47);
            this.sensitiveLabel.TabIndex = 0;
            this.sensitiveLabel.Text = "label1";
            this.sensitiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.zehirliLabel);
            this.panel6.Location = new System.Drawing.Point(345, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 50);
            this.panel6.TabIndex = 12;
            // 
            // zehirliLabel
            // 
            this.zehirliLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zehirliLabel.Location = new System.Drawing.Point(0, 3);
            this.zehirliLabel.Name = "zehirliLabel";
            this.zehirliLabel.Size = new System.Drawing.Size(64, 47);
            this.zehirliLabel.TabIndex = 0;
            this.zehirliLabel.Text = "label1";
            this.zehirliLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.coksagliksizLabel);
            this.panel7.Location = new System.Drawing.Point(281, 301);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(64, 50);
            this.panel7.TabIndex = 11;
            // 
            // coksagliksizLabel
            // 
            this.coksagliksizLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coksagliksizLabel.Location = new System.Drawing.Point(0, 3);
            this.coksagliksizLabel.Name = "coksagliksizLabel";
            this.coksagliksizLabel.Size = new System.Drawing.Size(64, 47);
            this.coksagliksizLabel.TabIndex = 0;
            this.coksagliksizLabel.Text = "label1";
            this.coksagliksizLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.sagliksizLabel);
            this.panel8.Location = new System.Drawing.Point(217, 301);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(64, 50);
            this.panel8.TabIndex = 10;
            // 
            // sagliksizLabel
            // 
            this.sagliksizLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sagliksizLabel.Location = new System.Drawing.Point(0, 3);
            this.sagliksizLabel.Name = "sagliksizLabel";
            this.sagliksizLabel.Size = new System.Drawing.Size(64, 47);
            this.sagliksizLabel.TabIndex = 0;
            this.sagliksizLabel.Text = "label1";
            this.sagliksizLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 3);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(25, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 3);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(25, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 3);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(855, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Hava Kalite Endeksi İzleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hkeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dominantPol;
        private System.Windows.Forms.Label karbonmonoksit;
        private System.Windows.Forms.Label lastUpdated;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label azotdioksit;
        private System.Windows.Forms.Label ozon;
        private System.Windows.Forms.Label basinc;
        private System.Windows.Forms.Label pm10;
        private System.Windows.Forms.Label pm25;
        private System.Windows.Forms.Label kukurtdioksit;
        private System.Windows.Forms.Label sicaklik;
        private System.Windows.Forms.Label ruzgar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label goodLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label moderateLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label sensitiveLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label zehirliLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label coksagliksizLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label sagliksizLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

