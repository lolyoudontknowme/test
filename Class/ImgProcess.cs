/*
 * Created by Ranorex
 * User: z-plat
 * Date: 11/21/2023
 * Time: 5:53 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
using System.Windows.Automation;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AOI_CRM_Eddie.Class
{
	/// <summary>
	/// Description of ImgProcess.
	/// </summary>
	public class ImgProcess
	{
		//Cat anh phien ban cu
		/*
		public static void captureAndCrop(Element inspConEle , string strFileName, int val, string savePath)
        {
            Bitmap bit = inspConEle.CaptureCompressedImage();
            Rectangle cropRect = new Rectangle(0, 0, bit.Height, bit.Width/val); // Ví dụ cắt từ tọa độ (100, 100) với kích thước 200x200
            Bitmap croppedImage = new Bitmap(cropRect.Height, cropRect.Width);
            using (Graphics graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(bit, new Rectangle(0, 0, croppedImage.Height, croppedImage.Width), cropRect, GraphicsUnit.Pixel);
            }
            croppedImage.Save(savePath + @"\" + strFileName + ".bmp");
        }*/
		
		//Compare Picture
		public static bool loadBitMap(string strPathImg, double para, Ranorex.Core.Element inspConEle)
        {
            Bitmap bmp = null;
            bmp = Ranorex.Imaging.Load(strPathImg);
            Ranorex.Imaging.FindOptions findOptions = new Ranorex.Imaging.FindOptions();
            findOptions.Similarity = para;
            bool flag = Ranorex.Imaging.Contains(inspConEle, bmp, findOptions);
            return flag;
        }
		
		//cat anh theo toa do cua element (phien ban moi)
		public static void capAndCropRGB(Element ele , string strFilename,int X,int Y,int wid,int hei,string savePath)
        {
            Bitmap bit = ele.CaptureCompressedImage();
            Rectangle cropRect = new Rectangle(X, Y, bit.Width/wid, bit.Height/hei); // Ví dụ cắt từ tọa độ (100, 100) với kích thước 200x200
            Bitmap croppedImage = new Bitmap(cropRect.Width, cropRect.Height);
            using (Graphics graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(bit, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height), cropRect, GraphicsUnit.Pixel);
            }
            //Bitmap resizedImage = new Bitmap(bit, bit.Height, bit.Width/2);
            
            DirectoryInfo di = new DirectoryInfo(savePath);
            string fullPath = di.FullName;
            croppedImage.Save(fullPath + @"\" + strFilename + ".bmp");
        }
		
		//Check the position of Mouse/ Mouse Button & get the value of text > Return value
		public static string getPointText()
        {
            System.Drawing.Point mouse = System.Windows.Forms.Cursor.Position;
            AutomationElement element = AutomationElement.FromPoint(new System.Windows.Point(mouse.X, mouse.Y));
            if (element == null)
            {
                Validate.Fail();
            }
            string txtName = element.Current.Name;
            return txtName;
        }
		
		/*public static bool CompareImages(string imagePath1, string imagePath2, double threshold)
        {
            // Load two images
            Bitmap image1 = new Bitmap(imagePath1);
            Bitmap image2 = new Bitmap(imagePath2);
            
            // Kiểm tra kích thước ảnh
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                return false;
            }
            
            int width = image1.Width;
            int height = image1.Height;
            
            // Tính toán sự khác biệt giữa hai ảnh
            int differentPixels = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel1 = image1.GetPixel(x, y);
                    Color pixel2 = image2.GetPixel(x, y);
                    
                    int deltaR = Math.Abs(pixel1.R - pixel2.R);
                    int deltaG = Math.Abs(pixel1.G - pixel2.G);
                    int deltaB = Math.Abs(pixel1.B - pixel2.B);
                    
                    if (deltaR + deltaG + deltaB > threshold)
                    {
                        differentPixels++;
                    }
                }
            }
            
            // Tính toán tỷ lệ khác biệt
            double differencePercentage = (double)differentPixels / (width * height);
            
            // Đặt ngưỡng để quyết định hai ảnh có giống nhau hay không
            if (differencePercentage <= threshold)
            {
                return true; // Giống nhau
            }
            else
            {
                return false; // Không giống nhau
            }
        }*/
	}
}
