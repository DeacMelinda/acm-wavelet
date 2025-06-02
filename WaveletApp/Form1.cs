using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WaveletApp
{
    public partial class Form1 : Form
    {
        private byte[,] originalImage = new byte[512, 512];
        private double[,] doublesImage = new double[512, 512];
        private byte[,] bytesImage = new byte[512, 512];
        private byte[] bmpHeader = new byte[1078];

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            scaleTextBox.Text = "10.3";
            offsetTextBox.Text = "12.8";
            xTextBox.Text = "256";
            yTextBox.Text = "512";
        }

        private void UpdateImageAndFields(int level)
        {
            double.TryParse(scaleTextBox.Text, out double scale);
            double.TryParse(offsetTextBox.Text, out double offset);
            int.TryParse(xTextBox.Text, out int x);
            int.TryParse(yTextBox.Text, out int y);

            int currentWidth = x >> level;
            int currentHeight = y >> level;

            // Only draw outside the approximation region
            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    if (i < currentHeight && j < currentWidth)
                    {
                        // Approximation region (top-left) already filled by SyH/SyV
                        continue;
                    }

                    // Draw detail coefficients in other 3 regions
                    double coeff = doublesImage[i, j];
                    int val = (int)(coeff * scale + offset);
                    val = Math.Max(0, Math.Min(255, val));
                    bytesImage[i, j] = (byte)val;
                }
            }

            // Optional: draw dividing lines (debug)
            //for (int i = 0; i < 512; i++) bytesImage[currentHeight, i] = 255;
            //for (int j = 0; j < 512; j++) bytesImage[j, currentWidth] = 255;

            // Shrink for next level
            xTextBox.Text = currentWidth.ToString();
            yTextBox.Text = currentHeight.ToString();
            scaleTextBox.Text = (scale * 0.9).ToString("F2");
            offsetTextBox.Text = (offset * 0.9).ToString("F2");

            waveletImageBox.Image = BytesToBitmap(bytesImage);
        }



        private Bitmap BytesToBitmap(byte[,] imageBytes)
        {
            int width = imageBytes.GetLength(1);
            int height = imageBytes.GetLength(0);
            Bitmap bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

            var palette = bmp.Palette;
            for (int i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bmp.Palette = palette;

            var bmpData = bmp.LockBits(new Rectangle(0, 0, width, height),
                                       System.Drawing.Imaging.ImageLockMode.WriteOnly,
                                       bmp.PixelFormat);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;

            byte[] data = new byte[stride * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    data[y * stride + x] = imageBytes[y, x];
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(data, 0, ptr, data.Length);
            bmp.UnlockBits(bmpData);

            return bmp;
        }


        private void originalmageLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a 512x512 .bmp image";
            ofd.Filter = "Image Files|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    byte[] header = new byte[1078];
                    fs.Read(header, 0, 1078);

                    for (int y = 511; y >= 0; y--)
                    {
                        for (int x = 0; x < 512; x++)
                        {
                            int pixelValue = fs.ReadByte();
                            originalImage[y, x] = (byte)pixelValue;
                        }
                    }
                    bmpHeader = header;
                }

                originalImageBox.Image = Image.FromFile(ofd.FileName);
                originalImageNameLabel.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private int RealIndexFor(int index, int size)
        {
            while (index < 0) index = -index;
            while (index >= size) index = 2 * size - index - 2;
            return index;
        }

        private void AnH(int row, int offsetX, int offsetY, int size)
        {
            double[] lineAnL = new double[size];
            double[] lineAnH = new double[size];

            for (int i = 0; i < size; i++)
            {
                double sumAnL = 0.0;
                double sumAnH = 0.0;
                int k = 0;

                for (int j = i - 4; j <= i + 4; j++, k++)
                {
                    int realX = RealIndexFor(j, size);
                    byte pixel = originalImage[offsetY + row, offsetX + realX];
                    sumAnL += Constants.AnalysisL[k] * pixel;
                    sumAnH += Constants.AnalysisH[k] * pixel;
                }

                lineAnL[i] = sumAnL;
                lineAnH[i] = sumAnH;
            }

            for (int i = 0; i < size; i += 2)
            {
                int idx = i / 2;
                doublesImage[offsetY + row, offsetX + idx] = lineAnL[i];                    // LL (left half)
                doublesImage[offsetY + row, offsetX + idx + size / 2] = lineAnH[i];         // HL (right half)
            }
        }

        private void AnV(int col, int offsetX, int offsetY, int size)
        {
            double[] lineAnL = new double[size];
            double[] lineAnH = new double[size];

            for (int i = 0; i < size; i++)
            {
                double sumAnL = 0.0;
                double sumAnH = 0.0;
                int k = 0;

                for (int j = i - 4; j <= i + 4; j++, k++)
                {
                    int realY = RealIndexFor(j, size);
                    double pixel = doublesImage[offsetY + realY, offsetX + col];
                    sumAnL += Constants.AnalysisL[k] * pixel;
                    sumAnH += Constants.AnalysisH[k] * pixel;
                }

                lineAnL[i] = sumAnL;
                lineAnH[i] = sumAnH;
            }

            for (int i = 0; i < size; i += 2)
            {
                int idx = i / 2;
                doublesImage[offsetY + idx, offsetX + col] = lineAnL[i];                    // LL (top half)
                doublesImage[offsetY + idx + size / 2, offsetX + col] = lineAnH[i];         // LH (bottom half)
            }
        }


        private void SyH(int row, int offsetX, int offsetY, int size)
        {
            double[] lineSyL = new double[size];
            double[] lineSyH = new double[size];

            // Fill lineSyL from LL (left half)
            for (int i = 0; i < size / 2; i++)
                lineSyL[2 * i] = doublesImage[offsetY + row, offsetX + i];

            // Fill lineSyH from HL (right half)
            for (int i = 0; i < size / 2; i++)
                lineSyH[2 * i + 1] = doublesImage[offsetY + row, offsetX + size / 2 + i];

            for (int i = 0; i < size; i++)
            {
                double sumSyL = 0.0;
                double sumSyH = 0.0;

                for (int k = 0, j = i - 4; j <= i + 4; j++, k++)
                {
                    int realIdx = RealIndexFor(j, size);
                    sumSyL += Constants.SynthesisL[k] * lineSyL[realIdx];
                    sumSyH += Constants.SynthesisH[k] * lineSyH[realIdx];
                }

                double result = sumSyL + sumSyH;
                result = Math.Max(0, Math.Min(255, result));
                bytesImage[offsetY + row, offsetX + i] = (byte)result;
            }
        }



        private void SyV(int col, int offsetX, int offsetY, int size)
        {
            double[] lineSyL = new double[size];
            double[] lineSyH = new double[size];

            // Fill from LL (top half)
            for (int i = 0; i < size / 2; i++)
                lineSyL[2 * i] = doublesImage[offsetY + i, offsetX + col];

            // Fill from LH (bottom half)
            for (int i = 0; i < size / 2; i++)
                lineSyH[2 * i + 1] = doublesImage[offsetY + size / 2 + i, offsetX + col];

            for (int i = 0; i < size; i++)
            {
                double sumSyL = 0.0;
                double sumSyH = 0.0;

                for (int k = 0, j = i - 4; j <= i + 4; j++, k++)
                {
                    int realIdx = RealIndexFor(j, size);
                    sumSyL += Constants.SynthesisL[k] * lineSyL[realIdx];
                    sumSyH += Constants.SynthesisH[k] * lineSyH[realIdx];
                }

                double result = sumSyL + sumSyH;
                result = Math.Max(0, Math.Min(255, result));
                bytesImage[offsetY + i, offsetX + col] = (byte)result;
            }
        }


        private void AnH1Button_Click(object sender, EventArgs e)
        {
            int size = 512;
            for (int row = 0; row < size; row++)
                AnH(row, 0, 0, size);

            UpdateImageAndFields(0);
        }


        private void AnV1Button_Click(object sender, EventArgs e)
        {
            int size = 512;
            for (int col = 0; col < size; col++)
                AnV(col, 0, 0, size);

            UpdateImageAndFields(0);
        }

        private void SyH1Button_Click(object sender, EventArgs e)
        {
            int size = 512;
            for (int row = 0; row < size; row++)
                SyH(row, 0, 0, size);

            UpdateImageAndFields(0);
        }

        private void SyV1Button_Click(object sender, EventArgs e)
        {
            int size = 512;
            for (int col = 0; col < size; col++)
                SyV(col, 0, 0, size);

            UpdateImageAndFields(0);
        }

        private void AnH2Button_Click(object sender, EventArgs e)
        {
            int size = 256;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                AnH(row, offsetX, offsetY, size);

            UpdateImageAndFields(1);  // Visualize level 2 decomposition
        }


        private void AnV2Button_Click(object sender, EventArgs e)
        {
            int size = 256;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                AnV(col, offsetX, offsetY, size);

            UpdateImageAndFields(1);  // Visualize level 2 layout
        }


        private void SyH2Button_Click(object sender, EventArgs e)
        {
            int size = 256;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                SyH(row, offsetX, offsetY, size);

            UpdateImageAndFields(1);  // Visualize partial reconstruction
        }


        private void SyV2Button_Click(object sender, EventArgs e)
        {
            int size = 256;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                SyV(col, offsetX, offsetY, size);

            UpdateImageAndFields(1);  // Show final approximation for level 2
        }

        private void AnH3Button_Click(object sender, EventArgs e)
        {
            int size = 128;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                AnH(row, offsetX, offsetY, size);

            UpdateImageAndFields(2);
        }

        private void AnV3Button_Click(object sender, EventArgs e)
        {
            int size = 128;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                AnV(col, offsetX, offsetY, size);

            UpdateImageAndFields(2);
        }


        private void SyH3Button_Click(object sender, EventArgs e)
        {
            int size = 128;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                SyH(row, offsetX, offsetY, size);

            UpdateImageAndFields(2);
        }


        private void SyV3Button_Click(object sender, EventArgs e)
        {
            int size = 128;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                SyV(col, offsetX, offsetY, size);

            UpdateImageAndFields(2);
        }

        private void AnH4Button_Click(object sender, EventArgs e)
        {
            int size = 64;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                AnH(row, offsetX, offsetY, size);

            UpdateImageAndFields(3);
        }


        private void AnV4Button_Click(object sender, EventArgs e)
        {
            int size = 64;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                AnV(col, offsetX, offsetY, size);

            UpdateImageAndFields(3);
        }

        private void SyH4Button_Click(object sender, EventArgs e)
        {
            int size = 64;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                SyH(row, offsetX, offsetY, size);

            UpdateImageAndFields(3);
        }


        private void SyV4Button_Click(object sender, EventArgs e)
        {
            int size = 64;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                SyV(col, offsetX, offsetY, size);

            UpdateImageAndFields(3);
        }


        private void AnH5Button_Click(object sender, EventArgs e)
        {
            int size = 32;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                AnH(row, offsetX, offsetY, size);

            UpdateImageAndFields(4);
        }


        private void AnV5Button_Click(object sender, EventArgs e)
        {
            int size = 32;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                AnV(col, offsetX, offsetY, size);

            UpdateImageAndFields(4);
        }

        private void SyH5Button_Click(object sender, EventArgs e)
        {
            int size = 32;
            int offsetX = 0;
            int offsetY = 0;

            for (int row = 0; row < size; row++)
                SyH(row, offsetX, offsetY, size);

            UpdateImageAndFields(4);
        }

        private void SyV5Button_Click(object sender, EventArgs e)
        {
            int size = 32;
            int offsetX = 0;
            int offsetY = 0;

            for (int col = 0; col < size; col++)
                SyV(col, offsetX, offsetY, size);

            UpdateImageAndFields(4);
        }

        private void minMaxErrorButton_Click(object sender, EventArgs e)
        {
            double minErr = int.MaxValue;
            double maxErr = int.MinValue;
            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    var err = originalImage[i, j] - bytesImage[i, j];
                    if (err < minErr) minErr = err;
                    if (err > maxErr) maxErr = err;
                }
            }

            minErrorTextBox.Text = minErr.ToString();
            maxErrorTextBox.Text = maxErr.ToString();
        }

        private void waveletRefreshButton_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = BytesToBitmap(bytesImage);
            waveletImageBox.Image = resultBitmap;
        }

    }
}
