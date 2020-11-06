namespace hw1
{
    partial class Form1
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
            this.HistogramEqualization = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // queryPictureBox
            // 
            this.queryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryPictureBox.Location = new System.Drawing.Point(53, 42);
            this.queryPictureBox.Name = "queryPictureBox";
            this.queryPictureBox.Size = new System.Drawing.Size(329, 251);
            this.queryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queryPictureBox.TabIndex = 0;
            this.queryPictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(53, 350);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(329, 251);
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
            this.ColorExtractionComboBox.Location = new System.Drawing.Point(739, 173);
            this.ColorExtractionComboBox.Name = "ColorExtractionComboBox";
            this.ColorExtractionComboBox.Size = new System.Drawing.Size(121, 20);
            this.ColorExtractionComboBox.TabIndex = 2;
            // 
            // RgbExtractionBtn
            // 
            this.RgbExtractionBtn.Enabled = false;
            this.RgbExtractionBtn.Location = new System.Drawing.Point(890, 170);
            this.RgbExtractionBtn.Name = "RgbExtractionBtn";
            this.RgbExtractionBtn.Size = new System.Drawing.Size(121, 23);
            this.RgbExtractionBtn.TabIndex = 3;
            this.RgbExtractionBtn.Text = "Color Extraction";
            this.RgbExtractionBtn.UseVisualStyleBackColor = true;
            this.RgbExtractionBtn.Click += new System.EventHandler(this.RgbExtractionBtn_Click);
            // 
            // ColorTransformationBtn
            // 
            this.ColorTransformationBtn.Enabled = false;
            this.ColorTransformationBtn.Location = new System.Drawing.Point(739, 199);
            this.ColorTransformationBtn.Name = "ColorTransformationBtn";
            this.ColorTransformationBtn.Size = new System.Drawing.Size(272, 23);
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
            this.SmoothComboBox.Location = new System.Drawing.Point(739, 257);
            this.SmoothComboBox.Name = "SmoothComboBox";
            this.SmoothComboBox.Size = new System.Drawing.Size(121, 20);
            this.SmoothComboBox.TabIndex = 5;
            // 
            // SmoothBtn
            // 
            this.SmoothBtn.Enabled = false;
            this.SmoothBtn.Location = new System.Drawing.Point(890, 255);
            this.SmoothBtn.Name = "SmoothBtn";
            this.SmoothBtn.Size = new System.Drawing.Size(121, 23);
            this.SmoothBtn.TabIndex = 6;
            this.SmoothBtn.Text = "Smooth Filter";
            this.SmoothBtn.UseVisualStyleBackColor = true;
            this.SmoothBtn.Click += new System.EventHandler(this.SmoothBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(739, 52);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(121, 23);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(890, 52);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save Image";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // HistogramEqualization
            // 
            this.HistogramEqualization.Enabled = false;
            this.HistogramEqualization.Location = new System.Drawing.Point(739, 312);
            this.HistogramEqualization.Name = "HistogramEqualization";
            this.HistogramEqualization.Size = new System.Drawing.Size(272, 23);
            this.HistogramEqualization.TabIndex = 9;
            this.HistogramEqualization.Text = "Histogram Equalization";
            this.HistogramEqualization.UseVisualStyleBackColor = true;
            this.HistogramEqualization.Click += new System.EventHandler(this.HistogramEqualization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Location = new System.Drawing.Point(739, 113);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(121, 23);
            this.PrevBtn.TabIndex = 12;
            this.PrevBtn.Text = "Prev Step";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Location = new System.Drawing.Point(890, 113);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(121, 23);
            this.NextBtn.TabIndex = 13;
            this.NextBtn.Text = "Next Step";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BinaryThresholdBtn
            // 
            this.BinaryThresholdBtn.Enabled = false;
            this.BinaryThresholdBtn.Location = new System.Drawing.Point(890, 372);
            this.BinaryThresholdBtn.Name = "BinaryThresholdBtn";
            this.BinaryThresholdBtn.Size = new System.Drawing.Size(121, 23);
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
            this.Threshold.Location = new System.Drawing.Point(740, 372);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(120, 22);
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
            this.SobelEdgeComboBox.Location = new System.Drawing.Point(740, 429);
            this.SobelEdgeComboBox.Name = "SobelEdgeComboBox";
            this.SobelEdgeComboBox.Size = new System.Drawing.Size(121, 20);
            this.SobelEdgeComboBox.TabIndex = 16;
            // 
            // SobelEdgeBtn
            // 
            this.SobelEdgeBtn.Enabled = false;
            this.SobelEdgeBtn.Location = new System.Drawing.Point(890, 429);
            this.SobelEdgeBtn.Name = "SobelEdgeBtn";
            this.SobelEdgeBtn.Size = new System.Drawing.Size(121, 23);
            this.SobelEdgeBtn.TabIndex = 17;
            this.SobelEdgeBtn.Text = "Sobel Edge Detection";
            this.SobelEdgeBtn.UseVisualStyleBackColor = true;
            this.SobelEdgeBtn.Click += new System.EventHandler(this.SobelEdgeBtn_Click);
            // 
            // OverlapBtn
            // 
            this.OverlapBtn.Enabled = false;
            this.OverlapBtn.Location = new System.Drawing.Point(740, 483);
            this.OverlapBtn.Name = "OverlapBtn";
            this.OverlapBtn.Size = new System.Drawing.Size(271, 23);
            this.OverlapBtn.TabIndex = 18;
            this.OverlapBtn.Text = "Threshold Overlap";
            this.OverlapBtn.UseVisualStyleBackColor = true;
            this.OverlapBtn.Click += new System.EventHandler(this.OverlapBtn_Click);
            // 
            // ImageRegistrationBtn
            // 
            this.ImageRegistrationBtn.Enabled = false;
            this.ImageRegistrationBtn.Location = new System.Drawing.Point(740, 542);
            this.ImageRegistrationBtn.Name = "ImageRegistrationBtn";
            this.ImageRegistrationBtn.Size = new System.Drawing.Size(271, 23);
            this.ImageRegistrationBtn.TabIndex = 19;
            this.ImageRegistrationBtn.Text = "Image Registration";
            this.ImageRegistrationBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 652);
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
            this.Controls.Add(this.HistogramEqualization);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SmoothBtn);
            this.Controls.Add(this.SmoothComboBox);
            this.Controls.Add(this.ColorTransformationBtn);
            this.Controls.Add(this.RgbExtractionBtn);
            this.Controls.Add(this.ColorExtractionComboBox);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.queryPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
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
        private System.Windows.Forms.Button HistogramEqualization;
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
    }
}

