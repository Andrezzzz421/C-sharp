using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.HELPER
{
    public class BSHelper
    {
        public static byte[] toByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image toImage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                Image image = Image.FromStream(ms);
                return new Bitmap(image);
            }
        }
    }
}
