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
    public partial class IPForm : Form
    {

        private List<Bitmap> BitmapList = new List<Bitmap>();
        private int ListIndex = -1;

        public IPForm()
        {
            InitializeComponent();

            ColorExtractionComboBox.SelectedIndex = 0;
            SmoothComboBox.SelectedIndex = 0;
            SobelEdgeComboBox.SelectedIndex = 0;
            listBoxOrigin.SelectedIndex = 0;
            listBoxResult.SelectedIndex = 0;

            OriginHistogram.Series[0].Color = Color.Red;
            OriginHistogram.Series[1].Color = Color.Green;
            OriginHistogram.Series[2].Color = Color.Blue;

            ResultHistogram.Series[0].Color = Color.Red;
            ResultHistogram.Series[1].Color = Color.Green;
            ResultHistogram.Series[2].Color = Color.Blue;
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

        private void ShowResultHistogram(Bitmap result)
        {

            foreach (var series in ResultHistogram.Series)
            {
                series.Points.Clear();
            }

            var Result = result.GetHistogram();
            for (int i = 0; i < 256; i++)
            {
                ResultHistogram.Series[0].Points.AddXY(i + 1, Result.Item1[i]);
                ResultHistogram.Series[1].Points.AddXY(i + 1, Result.Item2[i]);
                ResultHistogram.Series[2].Points.AddXY(i + 1, Result.Item3[i]);
            }

            for (int i = 0; i < ResultHistogram.Series.Count; i++)
            {
                if (i == listBoxResult.SelectedIndex)
                {
                    ResultHistogram.Series[i].Enabled = true;
                }
                else
                {
                    ResultHistogram.Series[i].Enabled = false;
                }
            }
        }

        private void ShowOriginHistogram(Bitmap origin)
        {

            foreach (var series in OriginHistogram.Series)
            {
                series.Points.Clear();
            }

            var Origin = origin.GetHistogram();
            for (int i = 0; i < 256; i++)
            {
                OriginHistogram.Series[0].Points.AddXY(i + 1, Origin.Item1[i]);
                OriginHistogram.Series[1].Points.AddXY(i + 1, Origin.Item2[i]);
                OriginHistogram.Series[2].Points.AddXY(i + 1, Origin.Item3[i]);
            }

            for (int i = 0; i < OriginHistogram.Series.Count; i++)
            {
                if (i == listBoxOrigin.SelectedIndex)
                {
                    OriginHistogram.Series[i].Enabled = true;
                }
                else
                {
                    OriginHistogram.Series[i].Enabled = false;
                }
            }


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
                    HistogramEqualizationBtn.Enabled = true;

                    ColorExtractionComboBox.Enabled = true;
                    SmoothComboBox.Enabled = true;
                    SobelEdgeComboBox.Enabled = true;

                    ShowOriginHistogram(bitmap);
                    ShowResultHistogram(bitmap);

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
                ShowResultHistogram(BitmapList[ListIndex]);
            }
            else
            {
                PrevBtn.Enabled = true;
                ListIndex = PrevIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
                ShowResultHistogram(BitmapList[ListIndex]);
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
                ShowResultHistogram(BitmapList[ListIndex]);
            }
            else
            {
                NextBtn.Enabled = true;
                ListIndex = NextIndex;
                resultPictureBox.Image = BitmapList[ListIndex];
                ShowResultHistogram(BitmapList[ListIndex]);
            }

            
        }



        private void listBoxOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < OriginHistogram.Series.Count; i++)
            {
                if (i == listBoxOrigin.SelectedIndex)
                {
                    OriginHistogram.Series[i].Enabled = true;
                }
                else
                {
                    OriginHistogram.Series[i].Enabled = false;
                }
            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ResultHistogram.Series.Count; i++)
            {
                if (i == listBoxResult.SelectedIndex)
                {
                    ResultHistogram.Series[i].Enabled = true;
                }
                else
                {
                    ResultHistogram.Series[i].Enabled = false;
                }
            }
        }


        private void RgbExtractionBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            int selected = ColorExtractionComboBox.SelectedIndex;
            if (selected == 0)  // R
            {
                img = img.ToRChannel();
                ShowResultHistogram(img);
                ListHandling(img);
            } else if (selected == 1)   // G
            {
                img = img.ToGChannel();
                ShowResultHistogram(img);
                ListHandling(img);
            } else if (selected == 2)   // B
            {
                img = img.ToBChannel();
                ShowResultHistogram(img);
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
            ShowResultHistogram(img);
            ListHandling(img);
        }


        private void SmoothBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            if (SmoothComboBox.SelectedIndex == 0)
            {
                // Mean
                img = img.SmoothFilterMean();
                ShowResultHistogram(img);
                ListHandling(img);
            } else if (SmoothComboBox.SelectedIndex == 1)
            {
                // Median
                img = img.SmoothFilterMedian();
                ShowResultHistogram(img);
                ListHandling(img);
            }
        }


        
        
        private void BinaryThresholdBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];
            img = img.BinaryThreshold(128);

            ShowResultHistogram(img);

            ListHandling(img);
        }

        private void HistogramEqualizationBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];

            img = img.HistogramEqualization();

            ShowResultHistogram(img);

            ListHandling(img);
        }

        private void SobelEdgeBtn_Click(object sender, EventArgs e)
        {
            Bitmap img = BitmapList[ListIndex];

            if (SobelEdgeComboBox.SelectedIndex == 0)
            {
                // Vertical
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Vertical);
                ShowResultHistogram(img);
                ListHandling(img);
            }
            else if (SobelEdgeComboBox.SelectedIndex == 1)
            {
                // Horizontal
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Horizontal);
                ShowResultHistogram(img);
                ListHandling(img);
            }
            else if (SobelEdgeComboBox.SelectedIndex == 2)
            {
                // Combined
                img = img.SobelEdgeDetection(BitmapExtension.SobelEdgeType.Combined);
                ShowResultHistogram(img);
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

