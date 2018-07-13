using System;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace Cars2._0.Models
{
    public static class Converters
    {
        public static Byte[] PathToByteArray(string path)
        {
            using (Stream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return new BinaryReader(fs).ReadBytes((int)fs.Length);
            }
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
