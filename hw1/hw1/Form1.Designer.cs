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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.Threshold = new System.Windows.Forms.DomainUpDown();
            this.SobelEdgeComboBox = new System.Windows.Forms.ComboBox();
            this.SobelEdgeBtn = new System.Windows.Forms.Button();
            this.OverlapBtn = new System.Windows.Forms.Button();
            this.ImageRegistrationBtn = new System.Windows.Forms.Button();
            this.OriginHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxOrigin = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // queryPictureBox
            // 
            this.queryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryPictureBox.Location = new System.Drawing.Point(39, 48);
            this.queryPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queryPictureBox.Name = "queryPictureBox";
            this.queryPictureBox.Size = new System.Drawing.Size(231, 194);
            this.queryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queryPictureBox.TabIndex = 0;
            this.queryPictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(39, 330);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(231, 194);
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
            this.ColorExtractionComboBox.Location = new System.Drawing.Point(817, 128);
            this.ColorExtractionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorExtractionComboBox.Name = "ColorExtractionComboBox";
            this.ColorExtractionComboBox.Size = new System.Drawing.Size(116, 26);
            this.ColorExtractionComboBox.TabIndex = 2;
            // 
            // RgbExtractionBtn
            // 
            this.RgbExtractionBtn.Enabled = false;
            this.RgbExtractionBtn.Location = new System.Drawing.Point(993, 123);
            this.RgbExtractionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RgbExtractionBtn.Name = "RgbExtractionBtn";
            this.RgbExtractionBtn.Size = new System.Drawing.Size(117, 28);
            this.RgbExtractionBtn.TabIndex = 3;
            this.RgbExtractionBtn.Text = "Color Extraction";
            this.RgbExtractionBtn.UseVisualStyleBackColor = true;
            this.RgbExtractionBtn.Click += new System.EventHandler(this.RgbExtractionBtn_Click);
            // 
            // ColorTransformationBtn
            // 
            this.ColorTransformationBtn.Enabled = false;
            this.ColorTransformationBtn.Location = new System.Drawing.Point(816, 182);
            this.ColorTransformationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorTransformationBtn.Name = "ColorTransformationBtn";
            this.ColorTransformationBtn.Size = new System.Drawing.Size(294, 28);
            this.ColorTransformationBtn.TabIndex = 4;
            this.ColorTransformationBtn.Text = "Color Transformation";
            this.ColorTransformationBtn.UseVisualStyleBackColor = true;
            this.ColorTransformationBtn.Click += new System.EventHandler(this.ColorTransformationBtn_Click);
            // 
            // SmoothComboBox
            // 
            this.SmoothComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SmoothComboBox.FormattingEnabled = true;
            this.SmoothComboBox.Items.AddRange(new object[] {
            "Mean",
            "Median"});
            this.SmoothComboBox.Location = new System.Drawing.Point(816, 240);
            this.SmoothComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmoothComboBox.Name = "SmoothComboBox";
            this.SmoothComboBox.Size = new System.Drawing.Size(117, 26);
            this.SmoothComboBox.TabIndex = 5;
            // 
            // SmoothBtn
            // 
            this.SmoothBtn.Enabled = false;
            this.SmoothBtn.Location = new System.Drawing.Point(992, 237);
            this.SmoothBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmoothBtn.Name = "SmoothBtn";
            this.SmoothBtn.Size = new System.Drawing.Size(118, 26);
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
            this.LoadBtn.Location = new System.Drawing.Point(817, 21);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(117, 28);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(993, 21);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 28);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save Image";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // HistogramEqualizationBtn
            // 
            this.HistogramEqualizationBtn.Enabled = false;
            this.HistogramEqualizationBtn.Location = new System.Drawing.Point(815, 291);
            this.HistogramEqualizationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HistogramEqualizationBtn.Name = "HistogramEqualizationBtn";
            this.HistogramEqualizationBtn.Size = new System.Drawing.Size(294, 26);
            this.HistogramEqualizationBtn.TabIndex = 9;
            this.HistogramEqualizationBtn.Text = "Histogram Equalization";
            this.HistogramEqualizationBtn.UseVisualStyleBackColor = true;
            this.HistogramEqualizationBtn.Click += new System.EventHandler(this.HistogramEqualizationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Location = new System.Drawing.Point(817, 75);
            this.PrevBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(117, 28);
            this.PrevBtn.TabIndex = 12;
            this.PrevBtn.Text = "Prev Step";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(993, 75);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(117, 28);
            this.NextBtn.TabIndex = 13;
            this.NextBtn.Text = "Next Step";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BinaryThresholdBtn
            // 
            this.BinaryThresholdBtn.Enabled = false;
            this.BinaryThresholdBtn.Location = new System.Drawing.Point(991, 342);
            this.BinaryThresholdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BinaryThresholdBtn.Name = "BinaryThresholdBtn";
            this.BinaryThresholdBtn.Size = new System.Drawing.Size(118, 26);
            this.BinaryThresholdBtn.TabIndex = 14;
            this.BinaryThresholdBtn.Text = "Binary Threshold";
            this.BinaryThresholdBtn.UseVisualStyleBackColor = true;
            this.BinaryThresholdBtn.Click += new System.EventHandler(this.BinaryThresholdBtn_Click);
            // 
            // Threshold
            // 
            this.Threshold.Enabled = false;
            this.Threshold.Items.Add("0");
            this.Threshold.Items.Add("1");
            this.Threshold.Items.Add("2");
            this.Threshold.Items.Add("3");
            this.Threshold.Items.Add("4");
            this.Threshold.Items.Add("5");
            this.Threshold.Items.Add("6");
            this.Threshold.Items.Add("7");
            this.Threshold.Items.Add("8");
            this.Threshold.Items.Add("9");
            this.Threshold.Items.Add("10");
            this.Threshold.Items.Add("11");
            this.Threshold.Items.Add("12");
            this.Threshold.Items.Add("13");
            this.Threshold.Items.Add("14");
            this.Threshold.Items.Add("15");
            this.Threshold.Items.Add("16");
            this.Threshold.Location = new System.Drawing.Point(816, 342);
            this.Threshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(117, 21);
            this.Threshold.TabIndex = 15;
            this.Threshold.Text = "Thershold";
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
            this.SobelEdgeComboBox.Location = new System.Drawing.Point(816, 400);
            this.SobelEdgeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SobelEdgeComboBox.Name = "SobelEdgeComboBox";
            this.SobelEdgeComboBox.Size = new System.Drawing.Size(117, 26);
            this.SobelEdgeComboBox.TabIndex = 16;
            // 
            // SobelEdgeBtn
            // 
            this.SobelEdgeBtn.Enabled = false;
            this.SobelEdgeBtn.Location = new System.Drawing.Point(991, 400);
            this.SobelEdgeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SobelEdgeBtn.Name = "SobelEdgeBtn";
            this.SobelEdgeBtn.Size = new System.Drawing.Size(118, 26);
            this.SobelEdgeBtn.TabIndex = 17;
            this.SobelEdgeBtn.Text = "Sobel Edge Detection";
            this.SobelEdgeBtn.UseVisualStyleBackColor = true;
            this.SobelEdgeBtn.Click += new System.EventHandler(this.SobelEdgeBtn_Click);
            // 
            // OverlapBtn
            // 
            this.OverlapBtn.Enabled = false;
            this.OverlapBtn.Location = new System.Drawing.Point(815, 457);
            this.OverlapBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverlapBtn.Name = "OverlapBtn";
            this.OverlapBtn.Size = new System.Drawing.Size(293, 26);
            this.OverlapBtn.TabIndex = 18;
            this.OverlapBtn.Text = "Threshold Overlap";
            this.OverlapBtn.UseVisualStyleBackColor = true;
            this.OverlapBtn.Click += new System.EventHandler(this.OverlapBtn_Click);
            // 
            // ImageRegistrationBtn
            // 
            this.ImageRegistrationBtn.Enabled = false;
            this.ImageRegistrationBtn.Location = new System.Drawing.Point(815, 512);
            this.ImageRegistrationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageRegistrationBtn.Name = "ImageRegistrationBtn";
            this.ImageRegistrationBtn.Size = new System.Drawing.Size(293, 26);
            this.ImageRegistrationBtn.TabIndex = 19;
            this.ImageRegistrationBtn.Text = "Image Registration";
            this.ImageRegistrationBtn.UseVisualStyleBackColor = true;
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
            this.OriginHistogram.Size = new System.Drawing.Size(493, 221);
            this.OriginHistogram.TabIndex = 20;
            this.OriginHistogram.Text = "Origin Chart";
            // 
            // ResultHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.ResultHistogram.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ResultHistogram.Legends.Add(legend4);
            this.ResultHistogram.Location = new System.Drawing.Point(286, 317);
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
            this.ResultHistogram.Size = new System.Drawing.Size(493, 221);
            this.ResultHistogram.TabIndex = 21;
            this.ResultHistogram.Text = "Result Histogram";
            // 
            // listBoxOrigin
            // 
            this.listBoxOrigin.FormattingEnabled = true;
            this.listBoxOrigin.ItemHeight = 18;
            this.listBoxOrigin.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.listBoxOrigin.Location = new System.Drawing.Point(673, 123);
            this.listBoxOrigin.Name = "listBoxOrigin";
            this.listBoxOrigin.Size = new System.Drawing.Size(92, 58);
            this.listBoxOrigin.TabIndex = 28;
            this.listBoxOrigin.SelectedIndexChanged += new System.EventHandler(this.listBoxOrigin_SelectedIndexChanged);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 18;
            this.listBoxResult.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.listBoxResult.Location = new System.Drawing.Point(673, 425);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(92, 58);
            this.listBoxResult.TabIndex = 29;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // IPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1148, 575);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxOrigin);
            this.Controls.Add(this.ResultHistogram);
            this.Controls.Add(this.OriginHistogram);
            this.Controls.Add(this.ImageRegistrationBtn);
            this.Controls.Add(this.OverlapBtn);
            this.Controls.Add(this.SobelEdgeBtn);
            this.Controls.Add(this.SobelEdgeComboBox);
            this.Controls.Add(this.Threshold);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
        private System.Windows.Forms.DomainUpDown Threshold;
        private System.Windows.Forms.ComboBox SobelEdgeComboBox;
        private System.Windows.Forms.Button SobelEdgeBtn;
        private System.Windows.Forms.Button OverlapBtn;
        private System.Windows.Forms.Button ImageRegistrationBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart OriginHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultHistogram;
        private System.Windows.Forms.ListBox listBoxOrigin;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

