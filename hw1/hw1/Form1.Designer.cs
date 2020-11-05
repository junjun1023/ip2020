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
            this.colorExtractionComboBox = new System.Windows.Forms.ComboBox();
            this.rgbExtractionBtn = new System.Windows.Forms.Button();
            this.colorTransformationBtn = new System.Windows.Forms.Button();
            this.SmoothComboBox = new System.Windows.Forms.ComboBox();
            this.SmoothBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // queryPictureBox
            // 
            this.queryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryPictureBox.Location = new System.Drawing.Point(236, 47);
            this.queryPictureBox.Name = "queryPictureBox";
            this.queryPictureBox.Size = new System.Drawing.Size(264, 224);
            this.queryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queryPictureBox.TabIndex = 0;
            this.queryPictureBox.TabStop = false;
            this.queryPictureBox.Click += new System.EventHandler(this.queryPictureBox_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(760, 47);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(264, 224);
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            // this.resultPictureBox.Click += new System.EventHandler(this.resultPictureBox_Click_1);
            // 
            // colorExtractionComboBox
            // 
            this.colorExtractionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorExtractionComboBox.FormattingEnabled = true;
            this.colorExtractionComboBox.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.colorExtractionComboBox.Location = new System.Drawing.Point(67, 314);
            this.colorExtractionComboBox.Name = "colorExtractionComboBox";
            this.colorExtractionComboBox.Size = new System.Drawing.Size(121, 20);
            this.colorExtractionComboBox.TabIndex = 2;
            this.colorExtractionComboBox.SelectedIndexChanged += new System.EventHandler(this.colorExtractionComboBox_SelectedIndexChanged);
            // 
            // rgbExtractionBtn
            // 
            this.rgbExtractionBtn.Location = new System.Drawing.Point(67, 340);
            this.rgbExtractionBtn.Name = "rgbExtractionBtn";
            this.rgbExtractionBtn.Size = new System.Drawing.Size(121, 23);
            this.rgbExtractionBtn.TabIndex = 3;
            this.rgbExtractionBtn.Text = "Color Extraction";
            this.rgbExtractionBtn.UseVisualStyleBackColor = true;
            this.rgbExtractionBtn.Click += new System.EventHandler(this.rgbExtractionBtn_Click);
            // 
            // colorTransformationBtn
            // 
            this.colorTransformationBtn.Location = new System.Drawing.Point(67, 370);
            this.colorTransformationBtn.Name = "colorTransformationBtn";
            this.colorTransformationBtn.Size = new System.Drawing.Size(121, 23);
            this.colorTransformationBtn.TabIndex = 4;
            this.colorTransformationBtn.Text = "Color Transformation";
            this.colorTransformationBtn.UseVisualStyleBackColor = true;
            this.colorTransformationBtn.Click += new System.EventHandler(this.colorTransformationBtn_Click);
            // 
            // SmoothComboBox
            // 
            this.SmoothComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SmoothComboBox.FormattingEnabled = true;
            this.SmoothComboBox.Items.AddRange(new object[] {
            "Mean",
            "Median"});
            this.SmoothComboBox.Location = new System.Drawing.Point(236, 314);
            this.SmoothComboBox.Name = "SmoothComboBox";
            this.SmoothComboBox.Size = new System.Drawing.Size(121, 20);
            this.SmoothComboBox.TabIndex = 5;
            // 
            // SmoothBtn
            // 
            this.SmoothBtn.Location = new System.Drawing.Point(236, 339);
            this.SmoothBtn.Name = "SmoothBtn";
            this.SmoothBtn.Size = new System.Drawing.Size(121, 23);
            this.SmoothBtn.TabIndex = 6;
            this.SmoothBtn.Text = "Smooth Filter";
            this.SmoothBtn.UseVisualStyleBackColor = true;
            this.SmoothBtn.Click += new System.EventHandler(this.SmoothBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 608);
            this.Controls.Add(this.SmoothBtn);
            this.Controls.Add(this.SmoothComboBox);
            this.Controls.Add(this.colorTransformationBtn);
            this.Controls.Add(this.rgbExtractionBtn);
            this.Controls.Add(this.colorExtractionComboBox);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.queryPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.queryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox queryPictureBox;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.ComboBox colorExtractionComboBox;
        private System.Windows.Forms.Button rgbExtractionBtn;
        private System.Windows.Forms.Button colorTransformationBtn;
        private System.Windows.Forms.ComboBox SmoothComboBox;
        private System.Windows.Forms.Button SmoothBtn;
    }
}

