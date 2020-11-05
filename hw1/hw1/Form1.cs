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

        Bitmap image;
        List<Bitmap> imageList = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void queryPictureBox_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageList.Clear();

                    imageLocation = dialog.FileName;
                    queryPictureBox.ImageLocation = imageLocation;
                    image = new Bitmap(Image.FromFile(imageLocation));
                    imageList.Add(image);

                    Bitmap imageRChannel = image.SmoothFilterMedian();
                    resultPictureBox.Image = imageRChannel;
                }
            } catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void rgbExtractionBtn_Click(object sender, EventArgs e)
        {
            
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = image.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        
                    int invR = Convert.ToInt32(255 - RGB.R);
                    int invG = Convert.ToInt32(255 - RGB.G);
                    int invB = Convert.ToInt32(255 - RGB.B);

                    image.SetPixel(x, y, Color.FromArgb(invR, invG, invB));
                }
            }
            resultPictureBox.Image = image;
        }

        private void colorTransformationBtn_Click(object sender, EventArgs e)
        {

        }

        private void colorExtractionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SmoothBtn_Click(object sender, EventArgs e)
        {

        }

        public static byte[] ImageToBuffer(Image Image, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            if (Image == null) { return null; }
            byte[] data = null;
            using (MemoryStream oMemoryStream = new MemoryStream())
            {
                //建立副本
                using (Bitmap oBitmap = new Bitmap(Image))
                {
                    //儲存圖片到 MemoryStream 物件，並且指定儲存影像之格式
                    oBitmap.Save(oMemoryStream, imageFormat);
                    //設定資料流位置
                    oMemoryStream.Position = 0;
                    //設定 buffer 長度
                    data = new byte[oMemoryStream.Length];
                    //將資料寫入 buffer
                    oMemoryStream.Read(data, 0, Convert.ToInt32(oMemoryStream.Length));
                    //將所有緩衝區的資料寫入資料流
                    oMemoryStream.Flush();
                }
            }
            return data;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = image.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        
                    int invR = Convert.ToInt32(255 - RGB.R);
                    int invG = Convert.ToInt32(255 - RGB.G);
                    int invB = Convert.ToInt32(255 - RGB.B);

                    image.SetPixel(x, y, Color.FromArgb(invR, invG, invB));
                }
            }
            resultPictureBox.Image = image;
        }

    }
}

