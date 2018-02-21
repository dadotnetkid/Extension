using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.ImageExtension
{
    public static class ImageHelper
    {
        public static byte[] ImageToByte(this Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    img.Save(ms, img.RawFormat);
                    return ms.ToArray();
                }
                catch (Exception)
                {

                    return null;
                }

            }
        }
        public static Image ByteToImage(this byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }
        public static string ImageToBase64(this Image img)
        {
            try
            {
                var bytes = img.ImageToByte();
                return Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                return "";
            }
            
        }
        public static Image ByteToImage(this string value)
        {
            var img = Convert.FromBase64String(value);
            return img.ByteToImage();
        }
    }
}
