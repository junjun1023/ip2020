namespace hw1
{
    partial class IPForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.queryPictureBox = new System.Windows.Forms.PictureBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorExtractionComboBox = new System.Windows.Forms.ComboBox();
            this.RgbExtractionBtn = new System.Windows.Forms.Button();
            this.ColorTransformationBtn = new System.Windows.Forms.Button();
            this.SmoothComboBox = new System.Windows.Forms.ComboBox();
            this.SmoothBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.HistogramEqualizationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.BinaryThresholdBtn = new System.Windows.Forms.Button();
            this.SobelEdgeComboBox = new System.Windows.Forms.ComboBox();
            this.SobelEdgeBtn = new System.Windows.Forms.Button();
            this.OverlapBtn = new System.Windows.Forms.Button();
            this.ImageRegistrationBtn = new System.Windows.Forms.Button();
            this.OriginHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.originListBox = new System.Windows.Forms.ListBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.RegisterImageA = new System.Windows.Forms.PictureBox();
            this.RegisterImageB = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegistration = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ThresoldUpDown = new System.Windows.Forms.NumericUpDown();
            this.LoadImageA = new System.Windows.Forms.Button();
            this.LoadImageB = new System.Windows.Forms.Button();
            this.RegistAListBox = new System.Windows.Forms.ListBox();
            this.RegistBListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImageA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImageB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresoldUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryPictureBox
            // 
            this.queryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryPictureBox.Location = new System.Drawing.Point(39, 48);
            this.queryPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queryPictureBox.Name = "queryPictureBox";
            this.queryPictureBox.Size = new System.Drawing.Size(226, 187);
            this.queryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queryPictureBox.TabIndex = 0;
            this.queryPictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(39, 268);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(226, 187);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            // 
            // ColorExtractionComboBox
            // 
            this.ColorExtractionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorExtractionComboBox.Enabled = false;
            this.ColorExtractionComboBox.FormattingEnabled = true;
            this.ColorExtractionComboBox.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.ColorExtractionComboBox.Location = new System.Drawing.Point(817, 140);
            this.ColorExtractionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorExtractionComboBox.Name = "ColorExtractionComboBox";
            this.ColorExtractionComboBox.Size = new System.Drawing.Size(135, 26);
            this.ColorExtractionComboBox.TabIndex = 2;
            // 
            // RgbExtractionBtn
            // 
            this.RgbExtractionBtn.Enabled = false;
            this.RgbExtractionBtn.Location = new System.Drawing.Point(975, 137);
            this.RgbExtractionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RgbExtractionBtn.Name = "RgbExtractionBtn";
            this.RgbExtractionBtn.Size = new System.Drawing.Size(135, 30);
            this.RgbExtractionBtn.TabIndex = 3;
            this.RgbExtractionBtn.Text = "Color Extraction";
            this.RgbExtractionBtn.UseVisualStyleBackColor = true;
            this.RgbExtractionBtn.Click += new System.EventHandler(this.RgbExtractionBtn_Click);
            // 
            // ColorTransformationBtn
            // 
            this.ColorTransformationBtn.Enabled = false;
            this.ColorTransformationBtn.Location = new System.Drawing.Point(817, 191);
            this.ColorTransformationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorTransformationBtn.Name = "ColorTransformationBtn";
            this.ColorTransformationBtn.Size = new System.Drawing.Size(292, 30);
            this.ColorTransformationBtn.TabIndex = 4;
            this.ColorTransformationBtn.Text = "Color Transformation";
            this.ColorTransformationBtn.UseVisualStyleBackColor = true;
            this.ColorTransformationBtn.Click += new System.EventHandler(this.ColorTransformationBtn_Click);
            // 
            // SmoothComboBox
            // 
            this.SmoothComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SmoothComboBox.Enabled = false;
            this.SmoothComboBox.FormattingEnabled = true;
            this.SmoothComboBox.Items.AddRange(new object[] {
            "Mean",
            "Median"});
            this.SmoothComboBox.Location = new System.Drawing.Point(817, 243);
            this.SmoothComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmoothComboBox.Name = "SmoothComboBox";
            this.SmoothComboBox.Size = new System.Drawing.Size(135, 26);
            this.SmoothComboBox.TabIndex = 5;
            // 
            // SmoothBtn
            // 
            this.SmoothBtn.Enabled = false;
            this.SmoothBtn.Location = new System.Drawing.Point(975, 239);
            this.SmoothBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmoothBtn.Name = "SmoothBtn";
            this.SmoothBtn.Size = new System.Drawing.Size(135, 30);
            this.SmoothBtn.TabIndex = 6;
            this.SmoothBtn.Text = "Smooth Filter";
            this.SmoothBtn.UseVisualStyleBackColor = true;
            this.SmoothBtn.Click += new System.EventHandler(this.SmoothBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.LoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoadBtn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LoadBtn.Location = new System.Drawing.Point(817, 30);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(135, 30);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(975, 30);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(135, 30);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save Image";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HistogramEqualizationBtn
            // 
            this.HistogramEqualizationBtn.Enabled = false;
            this.HistogramEqualizationBtn.Location = new System.Drawing.Point(817, 290);
            this.HistogramEqualizationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistogramEqualizationBtn.Name = "HistogramEqualizationBtn";
            this.HistogramEqualizationBtn.Size = new System.Drawing.Size(292, 30);
            this.HistogramEqualizationBtn.TabIndex = 9;
            this.HistogramEqualizationBtn.Text = "Histogram Equalization";
            this.HistogramEqualizationBtn.UseVisualStyleBackColor = true;
            this.HistogramEqualizationBtn.Click += new System.EventHandler(this.HistogramEqualizationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Location = new System.Drawing.Point(817, 68);
            this.PrevBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(135, 30);
            this.PrevBtn.TabIndex = 12;
            this.PrevBtn.Text = "Prev Step";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(974, 68);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(135, 30);
            this.NextBtn.TabIndex = 13;
            this.NextBtn.Text = "Next Step";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BinaryThresholdBtn
            // 
            this.BinaryThresholdBtn.Enabled = false;
            this.BinaryThresholdBtn.Location = new System.Drawing.Point(975, 340);
            this.BinaryThresholdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BinaryThresholdBtn.Name = "BinaryThresholdBtn";
            this.BinaryThresholdBtn.Size = new System.Drawing.Size(135, 30);
            this.BinaryThresholdBtn.TabIndex = 14;
            this.BinaryThresholdBtn.Text = "Binary Threshold";
            this.BinaryThresholdBtn.UseVisualStyleBackColor = true;
            this.BinaryThresholdBtn.Click += new System.EventHandler(this.BinaryThresholdBtn_Click);
            // 
            // SobelEdgeComboBox
            // 
            this.SobelEdgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SobelEdgeComboBox.Enabled = false;
            this.SobelEdgeComboBox.FormattingEnabled = true;
            this.SobelEdgeComboBox.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal",
            "Combined"});
            this.SobelEdgeComboBox.Location = new System.Drawing.Point(817, 396);
            this.SobelEdgeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SobelEdgeComboBox.Name = "SobelEdgeComboBox";
            this.SobelEdgeComboBox.Size = new System.Drawing.Size(135, 26);
            this.SobelEdgeComboBox.TabIndex = 16;
            // 
            // SobelEdgeBtn
            // 
            this.SobelEdgeBtn.Enabled = false;
            this.SobelEdgeBtn.Location = new System.Drawing.Point(974, 393);
            this.SobelEdgeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SobelEdgeBtn.Name = "SobelEdgeBtn";
            this.SobelEdgeBtn.Size = new System.Drawing.Size(135, 30);
            this.SobelEdgeBtn.TabIndex = 17;
            this.SobelEdgeBtn.Text = "Sobel Edge Detection";
            this.SobelEdgeBtn.UseVisualStyleBackColor = true;
            this.SobelEdgeBtn.Click += new System.EventHandler(this.SobelEdgeBtn_Click);
            // 
            // OverlapBtn
            // 
            this.OverlapBtn.Enabled = false;
            this.OverlapBtn.Location = new System.Drawing.Point(817, 439);
            this.OverlapBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverlapBtn.Name = "OverlapBtn";
            this.OverlapBtn.Size = new System.Drawing.Size(292, 30);
            this.OverlapBtn.TabIndex = 18;
            this.OverlapBtn.Text = "Threshold Overlap";
            this.OverlapBtn.UseVisualStyleBackColor = true;
            this.OverlapBtn.Click += new System.EventHandler(this.OverlapBtn_Click);
            // 
            // ImageRegistrationBtn
            // 
            this.ImageRegistrationBtn.Enabled = false;
            this.ImageRegistrationBtn.Location = new System.Drawing.Point(817, 638);
            this.ImageRegistrationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageRegistrationBtn.Name = "ImageRegistrationBtn";
            this.ImageRegistrationBtn.Size = new System.Drawing.Size(292, 30);
            this.ImageRegistrationBtn.TabIndex = 19;
            this.ImageRegistrationBtn.Text = "Image Registration";
            this.ImageRegistrationBtn.UseVisualStyleBackColor = true;
            this.ImageRegistrationBtn.Click += new System.EventHandler(this.ImageRegistrationBtn_Click);
            // 
            // OriginHistogram
            // 
            chartArea3.Name = "ChartArea1";
            this.OriginHistogram.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.OriginHistogram.Legends.Add(legend3);
            this.OriginHistogram.Location = new System.Drawing.Point(286, 30);
            this.OriginHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriginHistogram.Name = "OriginHistogram";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series3";
            this.OriginHistogram.Series.Add(series7);
            this.OriginHistogram.Series.Add(series8);
            this.OriginHistogram.Series.Add(series9);
            this.OriginHistogram.Size = new System.Drawing.Size(488, 214);
            this.OriginHistogram.TabIndex = 20;
            this.OriginHistogram.Text = "Origin Chart";
            // 
            // ResultHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.ResultHistogram.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ResultHistogram.Legends.Add(legend4);
            this.ResultHistogram.Location = new System.Drawing.Point(286, 255);
            this.ResultHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultHistogram.Name = "ResultHistogram";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series3";
            this.ResultHistogram.Series.Add(series10);
            this.ResultHistogram.Series.Add(series11);
            this.ResultHistogram.Series.Add(series12);
            this.ResultHistogram.Size = new System.Drawing.Size(488, 214);
            this.ResultHistogram.TabIndex = 21;
            this.ResultHistogram.Text = "Result Histogram";
            // 
            // originListBox
            // 
            this.originListBox.Enabled = false;
            this.originListBox.FormattingEnabled = true;
            this.originListBox.ItemHeight = 18;
            this.originListBox.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.originListBox.Location = new System.Drawing.Point(673, 123);
            this.originListBox.Name = "originListBox";
            this.originListBox.Size = new System.Drawing.Size(87, 58);
            this.originListBox.TabIndex = 28;
            this.originListBox.SelectedIndexChanged += new System.EventHandler(this.originListBox_SelectedIndexChanged);
            // 
            // resultListBox
            // 
            this.resultListBox.Enabled = false;
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 18;
            this.resultListBox.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.resultListBox.Location = new System.Drawing.Point(673, 351);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(87, 58);
            this.resultListBox.TabIndex = 29;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // RegisterImageA
            // 
            this.RegisterImageA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterImageA.Location = new System.Drawing.Point(3, 3);
            this.RegisterImageA.Name = "RegisterImageA";
            this.RegisterImageA.Size = new System.Drawing.Size(226, 189);
            this.RegisterImageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RegisterImageA.TabIndex = 30;
            this.RegisterImageA.TabStop = false;
            this.RegisterImageA.Click += new System.EventHandler(this.pictureBoxA_Click);
            // 
            // RegisterImageB
            // 
            this.RegisterImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterImageB.Location = new System.Drawing.Point(3, 3);
            this.RegisterImageB.Name = "RegisterImageB";
            this.RegisterImageB.Size = new System.Drawing.Size(231, 189);
            this.RegisterImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RegisterImageB.TabIndex = 31;
            this.RegisterImageB.TabStop = false;
            this.RegisterImageB.Click += new System.EventHandler(this.pictureBoxB_Click);
            // 
            // pictureBoxRegistration
            // 
            this.pictureBoxRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegistration.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRegistration.Name = "pictureBoxRegistration";
            this.pictureBoxRegistration.Size = new System.Drawing.Size(231, 189);
            this.pictureBoxRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRegistration.TabIndex = 32;
            this.pictureBoxRegistration.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Image A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Image B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Registration";
            // 
            // ThresoldUpDown
            // 
            this.ThresoldUpDown.Enabled = false;
            this.ThresoldUpDown.Location = new System.Drawing.Point(817, 344);
            this.ThresoldUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresoldUpDown.Name = "ThresoldUpDown";
            this.ThresoldUpDown.Size = new System.Drawing.Size(135, 21);
            this.ThresoldUpDown.TabIndex = 36;
            // 
            // LoadImageA
            // 
            this.LoadImageA.Location = new System.Drawing.Point(817, 519);
            this.LoadImageA.Name = "LoadImageA";
            this.LoadImageA.Size = new System.Drawing.Size(135, 30);
            this.LoadImageA.TabIndex = 37;
            this.LoadImageA.Text = "Load Image A";
            this.LoadImageA.UseVisualStyleBackColor = true;
            this.LoadImageA.Click += new System.EventHandler(this.LoadImageA_Click);
            // 
            // LoadImageB
            // 
            this.LoadImageB.Location = new System.Drawing.Point(976, 519);
            this.LoadImageB.Name = "LoadImageB";
            this.LoadImageB.Size = new System.Drawing.Size(135, 30);
            this.LoadImageB.TabIndex = 38;
            this.LoadImageB.Text = "Load Image B";
            this.LoadImageB.UseVisualStyleBackColor = true;
            this.LoadImageB.Click += new System.EventHandler(this.LoadImageB_Click);
            // 
            // RegistAListBox
            // 
            this.RegistAListBox.Enabled = false;
            this.RegistAListBox.FormattingEnabled = true;
            this.RegistAListBox.ItemHeight = 18;
            this.RegistAListBox.Location = new System.Drawing.Point(817, 555);
            this.RegistAListBox.Name = "RegistAListBox";
            this.RegistAListBox.Size = new System.Drawing.Size(135, 76);
            this.RegistAListBox.TabIndex = 39;
            this.RegistAListBox.DoubleClick += new System.EventHandler(this.RegistAListBox_DoubleClick);
            // 
            // RegistBListBox
            // 
            this.RegistBListBox.Enabled = false;
            this.RegistBListBox.FormattingEnabled = true;
            this.RegistBListBox.ItemHeight = 18;
            this.RegistBListBox.Location = new System.Drawing.Point(974, 555);
            this.RegistBListBox.Name = "RegistBListBox";
            this.RegistBListBox.Size = new System.Drawing.Size(135, 76);
            this.RegistBListBox.TabIndex = 40;
            this.RegistBListBox.DoubleClick += new System.EventHandler(this.RegistBListBox_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.RegisterImageA);
            this.panel1.Location = new System.Drawing.Point(41, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 189);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.RegisterImageB);
            this.panel2.Location = new System.Drawing.Point(286, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 189);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBoxRegistration);
            this.panel3.Location = new System.Drawing.Point(548, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 189);
            this.panel3.TabIndex = 43;
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Location = new System.Drawing.Point(817, 685);
            this.RegisterTextBox.Multiline = true;
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RegisterTextBox.Size = new System.Drawing.Size(292, 50);
            this.RegisterTextBox.TabIndex = 44;
            // 
            // IPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1155, 803);
            this.Controls.Add(this.RegisterTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegistBListBox);
            this.Controls.Add(this.RegistAListBox);
            this.Controls.Add(this.LoadImageB);
            this.Controls.Add(this.LoadImageA);
            this.Controls.Add(this.ThresoldUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.originListBox);
            this.Controls.Add(this.ResultHistogram);
            this.Controls.Add(this.OriginHistogram);
            this.Controls.Add(this.ImageRegistrationBtn);
            this.Controls.Add(this.OverlapBtn);
            this.Controls.Add(this.SobelEdgeBtn);
            this.Controls.Add(this.SobelEdgeComboBox);
            this.Controls.Add(this.BinaryThresholdBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistogramEqualizationBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SmoothBtn);
            this.Controls.Add(this.SmoothComboBox);
            this.Controls.Add(this.ColorTransformationBtn);
            this.Controls.Add(this.RgbExtractionBtn);
            this.Controls.Add(this.ColorExtractionComboBox);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.queryPictureBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IPForm";
            this.Text = "f";
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImageA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImageB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresoldUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox queryPictureBox;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.ComboBox ColorExtractionComboBox;
        private System.Windows.Forms.Button RgbExtractionBtn;
        private System.Windows.Forms.Button ColorTransformationBtn;
        private System.Windows.Forms.ComboBox SmoothComboBox;
        private System.Windows.Forms.Button SmoothBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button HistogramEqualizationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button BinaryThresholdBtn;
        private System.Windows.Forms.ComboBox SobelEdgeComboBox;
        private System.Windows.Forms.Button SobelEdgeBtn;
        private System.Windows.Forms.Button OverlapBtn;
        private System.Windows.Forms.Button ImageRegistrationBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart OriginHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultHistogram;
        private System.Windows.Forms.ListBox originListBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.PictureBox RegisterImageA;
        private System.Windows.Forms.PictureBox RegisterImageB;
        private System.Windows.Forms.PictureBox pictureBoxRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ThresoldUpDown;
        private System.Windows.Forms.Button LoadImageA;
        private System.Windows.Forms.Button LoadImageB;
        private System.Windows.Forms.ListBox RegistAListBox;
        private System.Windows.Forms.ListBox RegistBListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox RegisterTextBox;
    }
}

