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
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace UserFilterTester
{


    public abstract class ConvolutionFilterBase
    {
        public abstract string FilterName
        {
            get;set;
        }

        public abstract double Factor
        {
            get; set;
        }

        public abstract double Bias
        {
            get; set;
        }


        public abstract double[,] FilterMatrix
        {
            get; set;
        }

    }


    public class NoFilter : ConvolutionFilterBase
    {

        public override string FilterName
        {
            get { return "No Filter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0, 0, 0, },
                            { 0, 1, 0, },
                            { 0, 0, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class SobelFilter : ConvolutionFilterBase
    {

        public override string FilterName
        {
            get { return "SobelFilter"; }
            set { return; }
        }

        private double factor = 0.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0, 0, 0, },
                            { 0, 0, 0, },
                            { 0, 0, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class SoftenFilter : ConvolutionFilterBase
    {

        public override string FilterName
        {
            get { return "SoftenFilter"; }
            set { return; }
        }

        private double factor = 1.0 / 8.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 1, 1, 1, },
                            { 1, 1, 1, },
                            { 1, 1, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EmbossFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EmbossFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 127.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 2, 0, 0, },
                            { 0,-1, 0, },
                            { 0, 0,-1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EmbossTopLeftBottomRightFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EmbossTopLeftBottomRightFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 127.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, 0, 0, },
                            {  0, 0, 0, },
                            {  0, 0, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class HighPass3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "HighPass3x3Filter"; }
            set { return; }
        }

        private double factor = 1.0 / 16.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 127.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -2, -1, },
                            { -2, 12, -2, },
                            { -1, -2, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class SharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "SharpenFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, -1, },
                            { -1,  9, -1, },
                            { -1, -1, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class Sharpen3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Sharpen3x3Filter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0,-1, 0, },
                            { -1, 5, -1, },
                            { 0,-1, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class Sharpen3x3FactorFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Sharpen3x3FactorFilter"; }
            set { return; }
        }

        private double factor = 1.0 / 3.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { {  0, -2,  0, },
                            { -2, 11, -2, },
                            {  0, -2,  0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class IntenseSharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "IntenseSharpenFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 1,  1,  1, },
                            { 1, -7,  1, },
                            { 1,  1,  1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class Blur3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Blur3x3Filter"; }
            set { return; }
        }

        private double factor = 0.2;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0.0, 1.0, 0.0, },
                            { 1.0, 1.0, 1.0, },
                            { 0.0, 1.0, 1.0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class Gaussian3x3BlurFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Gaussian3x3BlurFilter"; }
            set { return; }
        }

        private double factor = 1.0 / 16.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 1, 2, 1, },
                            { 2, 4, 2, },
                            { 1, 2, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EdgeDetectionFilter1 : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionFilter1"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, -1, },
                            { -1,  8, -1, },
                            { -1, -1, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EdgeDetectionFilter2 : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionFilter2"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0, 1, 0, },
                            { 1,-4, 1, },
                            { 0, 1, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EdgeDetectionFilter3 : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionFilter3"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0, -1, 0, },
                            { -1, 4, -1, },
                            { 0, -1, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EdgeDetectionTopLeftBottomRightFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionTopLeftBottomRightFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { { -5,  0,  0, },
                            {  0,  0,  0, },
                            {  0,  0,  5, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }

    public class EdgeEnhanceFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeEnhanceFilter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set { return; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set { return; }
        }

        private double[,] filterMatrix =
            new double[,] { {  0,  0,  0, },
                            {  -1,  1,  0, },
                            {  0,  0,  0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }


    public class customFilter : ConvolutionFilterBase
    {

        public override string FilterName
        {
            get { return "Custom Filter"; }
            set { return; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
            set {
                factor = value;
                return;
            }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
            set
            {
                bias = value;
                return;
            }
        }

        private double[,] filterMatrix =
            new double[,] { { 0, 0, 0, },
                            { 0, 1, 0, },
                            { 0, 0, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
            set { return; }
        }
    }



    public static class ExtBitmap
    {
        public static Bitmap ConvolutionFilter<T>(this Bitmap sourceBitmap, T filter)
                                         where T : ConvolutionFilterBase
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filter.FilterMatrix.GetLength(1);
            int filterHeight = filter.FilterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filter.FilterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filter.FilterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filter.FilterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }

                    blue = filter.Factor * blue + filter.Bias;
                    green = filter.Factor * green + filter.Bias;
                    red = filter.Factor * red + filter.Bias;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                     ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap SobelFilter<T>(this Bitmap sourceBitmap, T filter)
                                         where T : ConvolutionFilterBase
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int filterWidth = filter.FilterMatrix.GetLength(1);
            int filterHeight = filter.FilterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    double blueX = 0.0;
                    double greenX = 0.0;
                    double redX = 0.0;
                    double blueY = 0.0;
                    double greenY = 0.0;
                    double redY = 0.0;
                    double blueT = 0.0;
                    double greenT = 0.0;
                    double redT = 0.0;

                    double[,] filterXX =  {
                                                { -1, 0, 1 },
                                                { -2, 0, 2 },
                                                { -1, 0, 1 }
                                            }; ;

                    double[,] filterYY = {
                                            {  1,  2,  1 },
                                            {  0,  0,  0 },
                                            { -1, -2, -1 }
                                        };

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);


                            blueX += (double)(pixelBuffer[calcOffset]) * filterXX[filterY + filterOffset, filterX + filterOffset];
                            greenX += (double)(pixelBuffer[calcOffset + 1]) * filterXX[filterY + filterOffset, filterX + filterOffset];
                            redX += (double)(pixelBuffer[calcOffset + 2]) * filterXX[filterY + filterOffset, filterX + filterOffset];
                            blueY += (double)(pixelBuffer[calcOffset]) * filterYY[filterY + filterOffset, filterX + filterOffset];
                            greenY += (double)(pixelBuffer[calcOffset + 1]) * filterYY[filterY + filterOffset, filterX + filterOffset];
                            redY += (double)(pixelBuffer[calcOffset + 2]) * filterYY[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    blueT = Math.Sqrt((blueX * blueX) + (blueY * blueY));
                    greenT = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    redT = Math.Sqrt((redX * redX) + (redY * redY));

                    if (blueT > 255)
                    { blueT = 255; }
                    else if (blueT < 0)
                    { blueT = 0; }

                    if (greenT > 255)
                    { greenT = 255; }
                    else if (greenT < 0)
                    { greenT = 0; }

                    if (redT > 255)
                    { redT = 255; }
                    else if (redT < 0)
                    { redT = 0; }

                    resultBuffer[byteOffset] = (byte)(blueT);
                    resultBuffer[byteOffset + 1] = (byte)(greenT);
                    resultBuffer[byteOffset + 2] = (byte)(redT);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                     ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }


    }

}