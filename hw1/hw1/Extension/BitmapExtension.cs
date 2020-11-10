using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using hw1.Custom;

namespace hw1.Extension
{
    public static class BitmapExtension
    {

        public enum SobelEdgeType
        {
            Vertical,
            Horizontal,
            Combined
        }


        public static Bitmap AddPadding(this Bitmap bitmap, int padding)
        {
            Bitmap change = new Bitmap(bitmap.Width + padding*2, bitmap.Height + padding*2);
            for (int y = 0; y < change.Height; y++)
            {
                for (int x = 0; x < change.Width; x++)
                {

                    if (x == 0 || y == 0 || x == change.Width - 1 || y == change.Height - 1)
                    {
                        change.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        Color value = bitmap.GetPixel(x-1, y-1);
                        change.SetPixel(x, y, value);
                    }
 
                }
            }


            return change;
        }


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
                    int invR = (int)Convert.ToInt32(RGB.R * 0.299);
                    int invG = (int)Convert.ToInt32(RGB.G * 0.587);
                    int invB = (int)Convert.ToInt32(RGB.B * 0.114);
                    int gray = invR + invG + invB;
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
            change = change.AddPadding(1);

            Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);

            Color color;
            float sumR = 0;
            float sumG = 0;
            float sumB = 0;

            for (int i = 1; i < change.Width - 1; i++)
            for (int j = 1; j < change.Height - 1; j++)
            {
                for (int x = i-1; x <= i + 1; x++)
                for (int y = j-1; y <= j + 1; y++)
                {
                    color = change.GetPixel(x, y);
                    sumR = sumR + color.R;
                    sumG = sumG + color.G;
                    sumB = sumB + color.B;
                }

                int meanR = (int)Math.Round(sumR / 9, 10);
                int meanG = (int)Math.Round(sumG / 9, 10);
                int meanB = (int)Math.Round(sumB / 9, 10);

                ret.SetPixel(i - 1, j - 1, Color.FromArgb(meanR, meanG, meanB));
                sumR = 0;
                sumG = 0;
                sumB = 0;
            }

            return ret;
        }

        public static Bitmap SmoothFilterMedian(this Bitmap bitmap)
        {
            Bitmap change = new Bitmap(bitmap);
            change = change.AddPadding(1);

            Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);

            List<int> termsList = new List<int>();

            for (int i = 1; i < change.Width - 1; i++)
            for (int j = 1; j < change.Height - 1; j++)
            {
                for (int x = i-1; x <= i + 1; x++)
                for (int y = j-1; y <= j + 1; y++)
                {
                    Color c = change.GetPixel(x, y);
                    termsList.Add(c.R);
                }
                int[] terms = termsList.ToArray();
                termsList.Clear();

                Array.Sort<int>(terms);
                Array.Reverse(terms);
                int color = terms[4];
                ret.SetPixel(i - 1, j - 1, Color.FromArgb(color, color, color));
            }

            return ret;
        }


        public static (int[], int[], int[]) GetHistogram(this Bitmap bitmap)
        {
            // Bitmap change = new Bitmap(bitmap);

            int[] cntR = new int[256];
            int[] cntG = new int[256];
            int[] cntB = new int[256];

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color color = bitmap.GetPixel(j, i);

                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    cntR[r]++;
                    cntG[g]++;
                    cntB[b]++;
                }
            }


            return (cntR, cntG, cntB);
        }


        public static Bitmap HistogramEqualization(this Bitmap bitmap)
        {
            Bitmap change = new Bitmap(bitmap);

            var histogram = change.GetHistogram();

            double[] pdfR = new double[256];
            double[] pdfG = new double[256];
            double[] pdfB = new double[256];

            for (int k = 0; k < 256; k++)
            {
                double valueR = histogram.Item1[k];
                double rate = valueR / (change.Height * change.Width * 1.0);
                pdfR[k] = rate;

                double valueG = histogram.Item2[k];
                rate = valueG / (change.Height * change.Width * 1.0);
                pdfG[k] = rate;

                double valueB = histogram.Item3[k];
                rate = valueB / (change.Height * change.Width * 1.0);
                pdfB[k] = rate;
            }


            for (int j = 0; j < change.Height; j++)
            {
                for (int i = 0; i < change.Width; i++)
                {
                    double densitySumR = 0;
                    double densitySumG = 0;
                    double densitySumB = 0;
                    Color value = change.GetPixel(i, j);
                    for (int k = 0; k <= value.R; k++)
                    {    //累積概率
                        densitySumR += pdfR[k];
                    }

                    for (int k = 0; k <= value.G; k++)
                    {    //累積概率
                        densitySumG += pdfG[k];
                    }

                    for (int k = 0; k <= value.B; k++)
                    {    //累積概率
                        densitySumB += pdfB[k];
                    }
                    byte r = (byte)Math.Round(255 * densitySumR);
                    byte g = (byte)Math.Round(255 * densitySumG);
                    byte b = (byte)Math.Round(255 * densitySumB);
                    Color newValue = Color.FromArgb(r, g, b);
                    change.SetPixel(i, j, newValue);
                }
            }
            return change;
        }


        public static Bitmap BinaryThreshold(this Bitmap bitmap, int threshold)
        {
            Bitmap change = new Bitmap(bitmap);
            change = change.ToGrayScale();

            for (int j = 0; j < change.Height; j++)
            {
                for (int i = 0; i < change.Width; i++)
                {
                    Color value = change.GetPixel(i, j);
                    int r = value.R >= threshold ? 255 : 0;
                    int g = value.G >= threshold ? 255 : 0;
                    int b = value.B >= threshold ? 255 : 0;

                    change.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            return change;
        }


        public static Bitmap SobelEdgeDetection(this Bitmap bitmap, SobelEdgeType type)
        {
            Bitmap change = new Bitmap(bitmap);
            change = change.ToGrayScale();
            change = change.AddPadding(1);
            Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);

            int[][] sobelx = {
                new int[] {-1, 0, 1},
                new int[] {-2, 0, 2},
                new int[] {-1, 0, 1}};

            int[][] sobely = {
                new int[] {-1, -2, -1},
                new int[] { 0, 0, 0},
                new int[] { 1, 2, 1}};

            int dx = 0;
            int dy = 0;

            switch (type)
            {
                case SobelEdgeType.Vertical:
                    for (int i = 1; i < change.Width - 1; i++)
                    {
                        for (int j = 1; j < change.Height - 1; j++)
                        {

                            for (int x = i - 1; x <= i + 1; x++)
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                dx += (change.GetPixel(x, y).R * sobely[x - i + 1][y - j + 1]);
                                dy += (change.GetPixel(x, y).R * sobely[x - i + 1][y - j + 1]);
                            }
                            double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                            if (derivata > 255)
                            {
                                ret.SetPixel(i - 1, j - 1, Color.Black);
                            }
                            else
                            {
                                ret.SetPixel(i - 1, j - 1, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                            }

                            dx = 0;
                            dy = 0;
                        }

                    }
                    break;

                case SobelEdgeType.Horizontal:

                    for (int i = 1; i < change.Width - 1; i++)
                    {
                        for (int j = 1; j < change.Height - 1; j++)
                        {

                            for (int x = i - 1; x <= i + 1; x++)
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                dx += (change.GetPixel(x, y).R * sobelx[x - i + 1][y - j + 1]);
                                dy += (change.GetPixel(x, y).R * sobelx[x - i + 1][y - j + 1]);
                            }
                            double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                            if (derivata > 255)
                            {
                                ret.SetPixel(i - 1, j - 1, Color.Black);
                            }
                            else
                            {
                                ret.SetPixel(i - 1, j - 1, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                            }

                            dx = 0;
                            dy = 0;
                        }

                    }
                    break;

                case SobelEdgeType.Combined:
  
                    for (int i = 1; i < change.Width - 1; i++)
                    {
                        for (int j = 1; j < change.Height - 1; j++)
                        {

                            for (int x = i - 1; x <= i + 1; x++)
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                dx += (change.GetPixel(x, y).R * sobelx[x - i + 1][y - j + 1]);
                                dy += (change.GetPixel(x, y).R * sobely[x - i + 1][y - j + 1]);
                            }
                            double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                            if (derivata > 255)
                            {
                                ret.SetPixel(i - 1, j - 1, Color.Black);
                            }
                            else
                            {
                                ret.SetPixel(i - 1, j - 1, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                            }

                            dx = 0;
                            dy = 0;
                        }

                    }
                    break;
            }

            return ret;
        }

        public static Bitmap OverlayMaskByGraphics(this Bitmap bitmap, Bitmap mask)
        {

            for (int i = 0; i < mask.Width; i++)
            for (int j = 0; j < mask.Height; j++)
            {
                Color color = mask.GetPixel(i, j);
                color = color.R == 0 ? Color.FromArgb(0, 0, 0, 0) : Color.FromArgb(128, 0, 255, 0);
                    mask.SetPixel(i, j, color);
            }


            Bitmap change = new Bitmap(bitmap.Width, bitmap.Height);

            using (Graphics gr = Graphics.FromImage(change))
            {
                gr.DrawImage(bitmap, new Point(0, 0));
                gr.DrawImage(mask, new Point(0, 0));
            }

            return change;
        }

        public static Bitmap OverlayMask(this Bitmap bitmap, Bitmap mask)
        {

            for (int i = 0; i < mask.Width; i++)
            for (int j = 0; j < mask.Height; j++)
            {
                Color color = mask.GetPixel(i, j);
                color = color.R == 0 ? Color.FromArgb(0, 0, 0) : Color.FromArgb(0, 255, 0);
                mask.SetPixel(i, j, color);
            }

            Bitmap change = new Bitmap(bitmap);

            for (int y = 0; y < mask.Height; y++)
            {
                for (int x = 0; x < mask.Width; x++)
                {
                    Color c = change.GetPixel(x, y);
                    Color m = mask.GetPixel(x, y);

                    int r = c.R + m.R;
                    int b = c.B + m.B;
                    int g = m.G == 255 ? m.G : c.G;
                    // int a = m.A == 128 ? m.A : c.A;
                    change.SetPixel(x, y, Color.FromArgb(r, g, b));
                 
                }
            }


            return change;
        }


        public static Bitmap Transformation(this Bitmap bitmap, Bitmap reference, double[,] mat)
        {
            /*
            int offsetX = (int) mat[2, 0];
            int offsetY = (int) mat[2, 1];
            double scaleX = Math.Sqrt(Math.Pow(mat[0, 0], 2) + Math.Pow(mat[0, 1], 2));
            double scaleY = Math.Sqrt(Math.Pow(mat[1, 0], 2) + Math.Pow(mat[1, 1], 2));
            double theta = Math.Atan(mat[0, 1] / mat[0, 0]);

            int width = (int) Math.Ceiling((bitmap.Width - offsetX) / Math.Cos(theta) / scaleX);
            int height = (int) Math.Ceiling(offsetX / Math.Sin(theta) / scaleY);
            */

            Bitmap change = new Bitmap(reference.Width, reference.Height);

            CustomMatrix customMatrix = new CustomMatrix();

            for (int i = 0; i < change.Width; i++)
            for (int j = 0; j < change.Height; j++)
            {

                double[,] coordinate = new double[1, 3]
                {
                    {i, j, 1}
                };

                coordinate = customMatrix.MatrixMultiply(coordinate, mat);
                int x = (int)Math.Round(coordinate[0, 0]);
                int y = (int)Math.Round(coordinate[0, 1]);

                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
                {
                    Color color = bitmap.GetPixel(x, y);

                    change.SetPixel(i, j, color);
                }

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

