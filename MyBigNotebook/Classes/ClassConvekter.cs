using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace MyBigNotebook.Classes
{
    class ClassConvert
    {
       static public string ConvertImageToBase64(string FileName)
        {
            string base64 = null;
            using (Bitmap bm = new Bitmap(FileName))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bm.Save(ms, ImageFormat.Jpeg);
                    base64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            return base64;
        }

        static public Image ConvertBase64ToImage(string Base64String)
        {
            Bitmap bm2;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Base64String)))
            {
                bm2 = new Bitmap(ms);

            }
            return bm2;
        }
    }
}
