using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace WinFormsAppStoreManagement.BLL
{
    public class ImageProcessing
    {
        Image image;

        public Image Image { get => image; set => image = value; }

        ImageProcessing() { }

        public static byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }
        public static Image ConvertByteArrayToImage(byte[] imageArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(imageArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
