using System;
using System.Collections.Generic;
using System.Drawing;

namespace hw1
{
    public static class BitmapExtension
    {
        public static Bitmap ToRChannel(this Bitmap bitmap)
        {

            Bitmap change = new Bitmap(bitmap);
            for (int y = 0; y < change.Height; y++)
            {
                for (int x = 0; x < change.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = change.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        
                    int invR = RGB.R;
                    // int invG = Convert.ToInt32(255 - RGB.G);
                    // int invB = Convert.ToInt32(255 - RGB.B);

                    change.SetPixel(x, y, Color.FromArgb(invR, invR, invR));
                }
            }

            return change;
        }

        public static Bitmap ToGChannel(this Bitmap bitmap)
        {

            Bitmap change = new Bitmap(bitmap);
            for (int y = 0; y < change.Height; y++)
            {
                for (int x = 0; x < change.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = change.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        
 
                    int invG = RGB.G;
                    // int invB = Convert.ToInt32(255 - RGB.B);

                    change.SetPixel(x, y, Color.FromArgb(invG, invG, invG));
                }
            }

            return change;
        }

        public static Bitmap ToBChannel(this Bitmap bitmap)
        {

            Bitmap change = new Bitmap(bitmap);
            for (int y = 0; y < change.Height; y++)
            {
                for (int x = 0; x < change.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = change.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        

                    int invB = RGB.B;

                    change.SetPixel(x, y, Color.FromArgb(invB, invB, invB));
                }
            }

            return change;
        }


        public static Bitmap ToGrayScale(this Bitmap bitmap)
        {

            Bitmap change = new Bitmap(bitmap);
            for (int y = 0; y < change.Height; y++)
            {
                for (int x = 0; x < change.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    Color RGB = change.GetPixel(x, y);
                    // RGB 是 VS 內建的 class 可以直接讀取影像的色彩資訊 R = Red, G = Green, B =Blue                        
                    int invR = RGB.R;
                    int invG = RGB.G;
                    int invB = RGB.B;

                    byte gray = (byte)(.333 * invR + .333 * invG + .333 * invB);
                    change.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    // int gray = (invR + invG + invB) / 3;
                    // change.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            return change;
        }


        public static Bitmap SmoothFilterMean(this Bitmap bitmap)
        {
            Bitmap change = new Bitmap(bitmap);

            change = change.ToGrayScale();

            Color color;
            float sum = 0;

            for (int i = 0; i <= change.Width - 3; i++)
            for (int j = 0; j <= change.Height - 3; j++)
            {
                for (int x = i; x <= i + 2; x++)
                for (int y = j; y <= j + 2; y++)
                {
                    color = change.GetPixel(x, y);
                    sum = sum + color.R;
                }

                int mean = (int) Math.Round(sum / 9, 10);
                change.SetPixel(i + 1, j + 1, Color.FromArgb(mean, mean, mean));
                sum = 0;

            }

            return change;
        }

        public static Bitmap SmoothFilterMedian(this Bitmap bitmap)
        {
            Bitmap change = new Bitmap(bitmap);

            change = change.ToGrayScale();

            List<int> termsList = new List<int>();
            Color c;

            for (int i = 0; i <= change.Width - 3; i++)
            for (int j = 0; j <= change.Height - 3; j++)
            {
                for (int x = i; x <= i + 2; x++)
                for (int y = j; y <= j + 2; y++)
                {

                    c = change.GetPixel(x, y);
                    termsList.Add(c.R);
                }
                int[] terms = termsList.ToArray();
                termsList.Clear();

                Array.Sort<int>(terms);
                Array.Reverse(terms);
                int color = terms[4];
                change.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
            }

            return change;
        }


        /*public static Bitmap SmoothFilterMean(this Bitmap bitmap)
        {
            Bitmap change = new Bitmap(bitmap);

            return change;
        }*/


    }
}

