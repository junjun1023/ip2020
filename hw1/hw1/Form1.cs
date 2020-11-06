using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1
{
    public partial class Form1 : Form
    {

        private List<Bitmap> BitmapList = new List<Bitmap>();
        private int ListIndex = -1;

        public Form1()
        {
            InitializeComponent();

            ColorExtractionComboBox.SelectedIndex = 0;
            SmoothComboBox.SelectedIndex = 0;
            SobelEdgeComboBox.SelectedIndex = 0;
        }

        private void ListHandling(Bitmap bitmap)
        {

            if (ListIndex < BitmapList.Count - 1)
            {
                for (int i = ListIndex + 1; i < BitmapList.Count; )
                {
                    BitmapList.RemoveAt(i);
                }
            }


            PrevBtn.Enabled = true;
            NextBtn.Enabled = false;
            BitmapList.Add(bitmap);
            ListIndex = BitmapList.Count - 1;
            resultPictureBox.Image = bitmap;
        }

        private void Load_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BitmapList.Clear();

                    String imageLocation = dialog.FileName;

                    Bitmap bitmap = new Bitmap(Image.FromFile(imageLocation));
                    BitmapList.Add(bitmap);

                    ListIndex = 0;
                    queryPictureBox.Image = BitmapList[ListIndex];
                    resultPictureBox.Image = BitmapList[ListIndex];

                    NextBtn.Enabled = false;
                    PrevBtn.Enabled = false;
                    ColorTransformationBtn.Enabled = true;
                    BinaryThresholdBtn.Enabled = true;
                    ImageRegistrationBtn.Enabled = true;
                    RgbExtractionBtn.Enabled = true;
                    OverlapBtn.Enabled = true;
                    SmoothBtn.Enabled = true;
                    SobelEdgeBtn.Enabled = true;

                    ColorExtractionComboBox.Enabled = true;
                    SmoothComboBox.Enabled = true;
                    SobelEdgeComboBox.Enabled = true;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            int PrevIndex = ListIndex - 1;

            if (PrevIndex < BitmapList.Count && ListIndex > 0)
            {
                NextBtn.Enabled = true;
            }
            else
            {
                NextBtn.Enabled = false;
            }

            if (PrevIndex < 0)
            {
                // Error
            }
            else if (PrevIndex == 0)
            {
                PrevBtn.Enabled = false;
                ListIndex = PrevIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
            }
            else
            {
                PrevBtn.Enabled = true;
                ListIndex = PrevIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            int NextIndex = ListIndex + 1;

            if (NextIndex < BitmapList.Count && ListIndex > 0)
            {
                PrevBtn.Enabled = true;
            }
            else
            {
                PrevBtn.Enabled = false;
            }


            if (NextIndex > BitmapList.Count - 1)
            {
                // Error: index out of range
            }
            else if (NextIndex == BitmapList.Count - 1)
            {
                NextBtn.Enabled = false;
                ListIndex = NextIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
            }
            else
            {
                NextBtn.Enabled = true;
                ListIndex = NextIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
            }

            
        }


        private void RgbExtractionBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            int selected = ColorExtractionComboBox.SelectedIndex;
            if (selected == 0)  // R
            {
                img = img.ToRChannel();
                ListHandling(img);
            } else if (selected == 1)   // G
            {
                img = img.ToGChannel();
                ListHandling(img);
            } else if (selected == 2)   // B
            {
                img = img.ToBChannel();
                ListHandling(img);
            }
            else
            {
                MessageBox.Show("Unknown Type Extraction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorTransformationBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            img = img.ToGrayScale();
            ListHandling(img);
        }


        private void SmoothBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            if (SmoothComboBox.SelectedIndex == 0)
            {
                // Mean
                img = img.SmoothFilterMean();
                ListHandling(img);
            } else if (SmoothComboBox.SelectedIndex == 1)
            {
                // Median
                img = img.SmoothFilterMedian();
                ListHandling(img);
            }
        }


        
        
        private void BinaryThresholdBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            img = img.BinaryThreshold(128);
            ListHandling(img);
        }

        private void HistogramEqualization_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            img = img.HistogramEqualization();
            ListHandling(img);
        }

        private void SobelEdgeBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];

            if (SobelEdgeComboBox.SelectedIndex == 0)
            {
                // Vertical
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Vertical);
                ListHandling(img);
            }
            else if (SobelEdgeComboBox.SelectedIndex == 1)
            {
                // Horizontal
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Horizontal);
                ListHandling(img);
            }
            else if (SobelEdgeComboBox.SelectedIndex == 2)
            {
                // Combined
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Combined);
                ListHandling(img);
            }
            
        }

        private void OverlapBtn_Click(object sender, EventArgs e)
        {
            Bitmap mask = BitmapList[ListIndex];
            Bitmap origin = BitmapList[0];

            Bitmap img = origin.OverlapImage(mask);
            ListHandling(img);
        }
    }
}

