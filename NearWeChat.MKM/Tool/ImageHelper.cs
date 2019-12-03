using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearWeChat.MKM.Tool
{
    public static class ImageHelper
    {
        public static Bitmap Base64StringToImage(string base64Img)
        {

            base64Img= base64Img.Replace("data:image/png;base64,", "").Replace("data:image/jgp;base64,", "").Replace("data:image/jpg;base64,", "").Replace("data:image/jpeg;base64,", "");
            base64Img = base64Img.Replace("data:img/jpg;base64,,", "").Replace("data:img/jgp;base64,", "").Replace("data:img/jpg;base64,", "").Replace("data:img/jpeg;base64,", "");

            byte[] bytes = Convert.FromBase64String(base64Img);
            MemoryStream ms = new MemoryStream();
            ms.Write(bytes, 0, bytes.Length);
            Bitmap bmp = new Bitmap(ms);

            return bmp;

        }
        public static string ImgToBase64String(Bitmap bmp)
        {

            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length);
            ms.Close();
            String strbaser64 = Convert.ToBase64String(arr);
            return strbaser64;

        }

        public static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, int width, int height)
        {
            Size size = new Size(width, height);
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }



    }
}
