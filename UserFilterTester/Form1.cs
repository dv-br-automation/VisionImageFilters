/*
 Microsoft Public License (MS-PL)
This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.

1. Definitions
The terms "reproduce," "reproduction," "derivative works," and "distribution" have the
same meaning here as under U.S. copyright law.

A "contribution" is the original software, or any additions or changes to the software.

A "contributor" is any person that distributes its contribution under this license.

"Licensed patents" are a contributor's patent claims that read directly on its contribution.

2. Grant of Rights

(A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.

(B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.

3. Conditions and Limitations

(A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.

(B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your patent license from such contributor to the software ends automatically.

(C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution notices that are present in the software.

(D) If you distribute any portion of the software in source code form, you may do so only under this license by including a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.

(E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement.
   
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace UserFilterTester
{
    public partial class ImageFilter : Form
    {

        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;


        public ImageFilter()
        {
            InitializeComponent();

            splitContainer1.Panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            splitContainer1.Panel2.AutoScroll = true;
            

            List<ConvolutionFilterBase> filterList = new List<ConvolutionFilterBase>();

            filterList.Add(new NoFilter());
            filterList.Add(new SobelFilter());
            filterList.Add(new SoftenFilter());
            filterList.Add(new EmbossFilter());
            filterList.Add(new EmbossTopLeftBottomRightFilter());
            filterList.Add(new HighPass3x3Filter());
            filterList.Add(new SharpenFilter());
            filterList.Add(new Sharpen3x3Filter());
            filterList.Add(new Sharpen3x3FactorFilter());
            filterList.Add(new IntenseSharpenFilter());
            filterList.Add(new Blur3x3Filter());
            filterList.Add(new Gaussian3x3BlurFilter());
            filterList.Add(new EdgeEnhanceFilter());
            filterList.Add(new EdgeDetectionFilter1());
            filterList.Add(new EdgeDetectionFilter2());
            filterList.Add(new EdgeDetectionTopLeftBottomRightFilter());
            filterList.Add(new customFilter());
            
            convolutionFilter.DataSource = filterList;
            convolutionFilter.DisplayMember = "FilterName";
            convolutionFilter.SelectedIndex = 0;

            applyFilter.Enabled = false;
            saveImage.Enabled = false;

            enableEntries(false);

        }


        private void loadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = resultBitmap;

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.AddExtension = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Select an image file.";
            openFileDialog1.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";//  "Png Images(*.png)|*.png|Jpg Images(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sourceFile = @openFileDialog1.FileName;
                string destinationFile = @"Image";
                System.IO.File.Copy(sourceFile, destinationFile, true);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.LoadAsync(@"Image");
                splitContainer1.Panel1.AutoScroll = true;

                StreamReader streamReader = new StreamReader(@openFileDialog1.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap;
                applyFilter.Enabled = true;
            }
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            if (cbEnableGray.Checked | (convolutionFilter.SelectedItem is SobelFilter))
            {
                previewBitmap = grayscale(originalBitmap);
            }
            else
            {
                previewBitmap = originalBitmap;
            }

            ConvolutionFilterBase filter = null;

            if (convolutionFilter.SelectedItem is ConvolutionFilterBase)
            {
                filter = (ConvolutionFilterBase)convolutionFilter.SelectedItem;
            }

            if (convolutionFilter.SelectedItem is SobelFilter)
            {
                resultBitmap = previewBitmap.SobelFilter(filter);
            }
            else
            {
                resultBitmap = previewBitmap.ConvolutionFilter(filter);
            }
                
            pictureBox1.Image = resultBitmap;

            saveImage.Enabled = true;

        }

        

        private void convolutionFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (convolutionFilter.SelectedItem is ConvolutionFilterBase)
            {
                if (convolutionFilter.SelectedItem is customFilter)
                {
                    enableEntries(true);
                    matrix_Changed(sender,e);
                }
                else
                {
                    enableEntries(false);
                    updateMatrixText();
                }
            }
        }


        private Bitmap grayscale(Image image)
        {
            Bitmap btm = new Bitmap(image);
            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    int ser = (btm.GetPixel(i, j).R + btm.GetPixel(i, j).G + btm.GetPixel(i, j).B) / 3;
                    btm.SetPixel(i, j, Color.FromArgb(ser, ser, ser));
                }
            }
            return btm;
        }

        public void enableEntries(bool enable)
        {
            bool _enable = enable;
            numMatrix11.Enabled = _enable;
            numMatrix12.Enabled = _enable;
            numMatrix13.Enabled = _enable;
            numMatrix21.Enabled = _enable;
            numMatrix22.Enabled = _enable;
            numMatrix23.Enabled = _enable;
            numMatrix31.Enabled = _enable;
            numMatrix32.Enabled = _enable;
            numMatrix33.Enabled = _enable;
            numMatrixGain.Enabled = _enable;
            numMatrixOffset.Enabled = _enable;

            return;
        }

        public bool enableEntries()
        {
            return numMatrix11.Enabled;
        }



            private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image File (*.png)|*.png";
            dialog.DefaultExt = "png";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                resultBitmap.Save(dialog.FileName, ImageFormat.Png);

            }
        }



        private void matrix_Changed(object sender, EventArgs e)
        {
            if (enableEntries())
            {
                ConvolutionFilterBase filter = (ConvolutionFilterBase)convolutionFilter.SelectedItem;

                filter.Bias = Convert.ToDouble(numMatrixOffset.Value);
                filter.Factor = Convert.ToDouble(numMatrixGain.Value) / 32768;
                filter.FilterMatrix[0, 0] = Convert.ToDouble(numMatrix11.Value);
                filter.FilterMatrix[0, 1] = Convert.ToDouble(numMatrix12.Value);
                filter.FilterMatrix[0, 2] = Convert.ToDouble(numMatrix13.Value);
                filter.FilterMatrix[1, 0] = Convert.ToDouble(numMatrix21.Value);
                filter.FilterMatrix[1, 1] = Convert.ToDouble(numMatrix22.Value);
                filter.FilterMatrix[1, 2] = Convert.ToDouble(numMatrix23.Value);
                filter.FilterMatrix[2, 0] = Convert.ToDouble(numMatrix31.Value);
                filter.FilterMatrix[2, 1] = Convert.ToDouble(numMatrix32.Value);
                filter.FilterMatrix[2, 2] = Convert.ToDouble(numMatrix33.Value);
            }
            updateMatrixText();
        }

        private void updateMatrixText()
        {

            ConvolutionFilterBase filter1 = (ConvolutionFilterBase)convolutionFilter.SelectedItem;

            numMatrix11.Value = Convert.ToDecimal(filter1.FilterMatrix[0, 0]);
            numMatrix12.Value = Convert.ToDecimal(filter1.FilterMatrix[0, 1]);
            numMatrix13.Value = Convert.ToDecimal(filter1.FilterMatrix[0, 2]);
            numMatrix21.Value = Convert.ToDecimal(filter1.FilterMatrix[1, 0]);
            numMatrix22.Value = Convert.ToDecimal(filter1.FilterMatrix[1, 1]);
            numMatrix23.Value = Convert.ToDecimal(filter1.FilterMatrix[1, 2]);
            numMatrix31.Value = Convert.ToDecimal(filter1.FilterMatrix[2, 0]);
            numMatrix32.Value = Convert.ToDecimal(filter1.FilterMatrix[2, 1]);
            numMatrix33.Value = Convert.ToDecimal(filter1.FilterMatrix[2, 2]);
            numMatrixOffset.Value = Convert.ToDecimal(filter1.Bias);
            numMatrixGain.Value = Convert.ToDecimal(filter1.Factor) * 32768;

            lbFilter11.Text = filter1.FilterMatrix[0, 0].ToString();
            lbFilter12.Text = filter1.FilterMatrix[0, 1].ToString();
            lbFilter13.Text = filter1.FilterMatrix[0, 2].ToString();
            lbFilter21.Text = filter1.FilterMatrix[1, 0].ToString();
            lbFilter22.Text = filter1.FilterMatrix[1, 1].ToString();
            lbFilter23.Text = filter1.FilterMatrix[1, 2].ToString();
            lbFilter31.Text = filter1.FilterMatrix[2, 0].ToString();
            lbFilter32.Text = filter1.FilterMatrix[2, 1].ToString();
            lbFilter33.Text = filter1.FilterMatrix[2, 2].ToString();
            lbOffsetandPlus.Text = "X Image + " + filter1.Bias.ToString();
            lbGainAndMultiplier.Text = String.Format("{0:0.00}", filter1.Factor) + " X ";
        }

        private void ImageFilter_Load(object sender, EventArgs e)
        {

        }
    }


}
