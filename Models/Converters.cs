using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Cars2._0.Models
{
    public static class Converters
    {
        /// <summary>
        /// Does not work properly need to be fixed
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static Byte[] BitmapImageToByteArray(BitmapImage image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var cropped = new CroppedBitmap(image, new System.Windows.Int32Rect(0, 0, (int)image.Width, (int)image.Height));
                byte[] bytesArray = new byte[(int)(cropped.Width * cropped.Height) + 1];
                cropped.CopyPixels(bytesArray, (int)(cropped.Width * cropped.Height), (int)(cropped.PixelWidth * cropped.PixelHeight ));
                return bytesArray;
            }
        }

        public static BitmapImage UriToBitmapImage(string Path)
        {
            return new BitmapImage(new Uri(Path));
        }
        public static BitmapImage BitmapFromByteArray(Byte[] bytes)
        {
            var img = new BitmapImage();
            using (var ms = new MemoryStream(bytes))
            {
                img.BeginInit();
                img.StreamSource = ms;
                img.EndInit();

                return img;               
            }
        }
    }
}
