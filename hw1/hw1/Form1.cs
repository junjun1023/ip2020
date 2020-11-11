using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hw1.Custom;
using hw1.Extension;

namespace hw1
{
    public partial class IPForm : Form
    {

        private List<Bitmap> BitmapList = new List<Bitmap>();
        private int ListIndex = -1;

        private CustomMatrix customMatrix = new CustomMatrix();
        private List<(int, int)> RegistA = new List<(int, int)>();
        private List<(int, int)> RegistB = new List<(int, int)>();

        public IPForm()
        {
            InitializeComponent();

            ColorExtractionComboBox.SelectedIndex = 0;
            SmoothComboBox.SelectedIndex = 0;
            SobelEdgeComboBox.SelectedIndex = 0;
            originListBox.SelectedIndex = 0;
            resultListBox.SelectedIndex = 0;

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
                for (int i = ListIndex + 1; i < BitmapList.Count;)
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
                if (i == resultListBox.SelectedIndex)
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
                if (i == originListBox.SelectedIndex)
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
                    RgbExtractionBtn.Enabled = true;
                    OverlapBtn.Enabled = true;
                    SmoothBtn.Enabled = true;
                    SobelEdgeBtn.Enabled = true;
                    HistogramEqualizationBtn.Enabled = true;

                    ColorExtractionComboBox.Enabled = true;
                    SmoothComboBox.Enabled = true;
                    SobelEdgeComboBox.Enabled = true;

                    ThresoldUpDown.Enabled = true;

                    originListBox.Enabled = true;
                    resultListBox.Enabled = true;

                    ShowOriginHistogram(bitmap);
                    ShowResultHistogram(bitmap);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BitmapList[ListIndex].Save(sfd.FileName);
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



        private void originListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < OriginHistogram.Series.Count; i++)
            {
                if (i == originListBox.SelectedIndex)
                {
                    OriginHistogram.Series[i].Enabled = true;
                }
                else
                {
                    OriginHistogram.Series[i].Enabled = false;
                }
            }
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ResultHistogram.Series.Count; i++)
            {
                if (i == resultListBox.SelectedIndex)
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
            if (selected == 0) // R
            {
                img = img.ToRChannel();
                ShowResultHistogram(img);
                ListHandling(img);
            }
            else if (selected == 1) // G
            {
                img = img.ToGChannel();
                ShowResultHistogram(img);
                ListHandling(img);
            }
            else if (selected == 2) // B
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
            }
            else if (SmoothComboBox.SelectedIndex == 1)
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
            var threshold = ThresoldUpDown.Value;
            img = img.BinaryThreshold(Convert.ToInt32(threshold));

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
            Bitmap img = origin.OverlayMask(mask);
            ListHandling(img);
        }


        private void LoadImageA_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    RegistAListBox.Items.Clear();
                    RegistA.Clear();

                    String imageLocation = dialog.FileName;
                    RegisterImageA.ImageLocation = imageLocation;
                    RegistAListBox.Enabled = true;
                    ImageRegistrationBtn.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImageB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    RegistBListBox.Items.Clear();
                    RegistB.Clear();
                    String imageLocation = dialog.FileName;
                    RegisterImageB.ImageLocation = imageLocation;
                    RegistBListBox.Enabled = true;
                    ImageRegistrationBtn.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {
            if (RegisterImageA.Image != null)
            {
                MouseEventArgs mouse = (MouseEventArgs) e;
                
                (int, int) coordinate = (mouse.X, mouse.Y);

                RegistAListBox.Items.Add(coordinate);
                RegistA.Add(coordinate);

                if (RegistAListBox.Items.Count >= 4)
                {
                    if (RegistBListBox.Items.Count == 4)
                    {
                        ImageRegistrationBtn.Enabled = true;
                    }
                    return;
                }

            }
        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {
            if (RegisterImageB.Image != null)
            {
                MouseEventArgs mouse = (MouseEventArgs)e;

                (int, int) coordinate = (mouse.X, mouse.Y);

                RegistBListBox.Items.Add(coordinate);
                RegistB.Add(coordinate);
                if (RegistBListBox.Items.Count >= 4)
                {
                    if (RegistAListBox.Items.Count == 4)
                    {
                        ImageRegistrationBtn.Enabled = true;
                    }
                    return;
                }

            }
        }

        private void RegistAListBox_DoubleClick(object sender, EventArgs e)
        {
            RegistAListBox.Items.RemoveAt(RegistAListBox.SelectedIndex);
            RegistA.RemoveAt(RegistAListBox.SelectedIndex);
            ImageRegistrationBtn.Enabled = false;
        }

        private void RegistBListBox_DoubleClick(object sender, EventArgs e)
        {
            RegistBListBox.Items.RemoveAt(RegistBListBox.SelectedIndex);
            RegistB.RemoveAt(RegistAListBox.SelectedIndex);
            ImageRegistrationBtn.Enabled = false;
        }

        private void ImageRegistrationBtn_Click(object sender, EventArgs e)
        {
            Debug.Assert(RegistAListBox.Items.Count == 4, "Registration should select exact 4 points");
            Debug.Assert(RegistBListBox.Items.Count == 4, "Registration should select exact 4 points");

            double[,] validA = new double[3, 3]
            {
                {RegistA[0].Item1, RegistA[0].Item2, 1},
                {RegistA[1].Item1, RegistA[1].Item2, 1},
                {RegistA[2].Item1, RegistA[2].Item2, 1},
            };
            double[,] validB = new double[3, 3]
            {
                {RegistB[0].Item1, RegistB[0].Item2, 1},
                {RegistB[1].Item1, RegistB[1].Item2, 1},
                {RegistB[2].Item1, RegistB[2].Item2, 1},
            };

            validA = customMatrix.MatrixInverse<double>(validA);
            validA = customMatrix.MatrixMultiply(validA, validB);   // transformation matrix

            // scale then rotate
            var cx = Math.Sqrt(Math.Pow(validA[0, 0], 2) + Math.Pow(validA[0, 1], 2));
            var cy = Math.Sqrt(Math.Pow(validA[1, 0], 2) + Math.Pow(validA[1, 1], 2));
            var theta = Math.Atan(validA[0, 1] / validA[0, 0]) / Math.PI * 180;
            


            // rotate then scale
            var cx_2 = Math.Sqrt(Math.Pow(validA[0, 0], 2) + Math.Pow(validA[1, 0], 2));
            var cy_2 = Math.Sqrt(Math.Pow(validA[0, 1], 2) + Math.Pow(validA[1, 1], 2));
            var theta_2 = Math.Atan(validA[1, 1] / validA[0, 1]) / Math.PI * 180;

            // validate rotate and scale by 4th value
            // because matrix satisfy associative law
            // so there will be two same results for different orders of rotate and scale

            // double[,] validAInversse = new double[3,3];
            // validAInversse = customMatrix.MatrixInverse<double>(validA);

            Bitmap img = new Bitmap(RegisterImageB.Image);
            Bitmap reference = new Bitmap(RegisterImageA.Image);
            img = img.Transformation(reference, validA);
            pictureBoxRegistration.Image = img;

            double difference = img.IntensityDifference(reference);

            RegisterTextBox.Text = $"Scale factor: {cx}" + Environment.NewLine + 
                                   $"Rotate Angle: {theta}" + Environment.NewLine +
                                   $"Intensity Difference: {difference}";
        }

        private void GetTransformation()
        {

        }
    }
}

