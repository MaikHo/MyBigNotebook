using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace MyBigNotebook.Classes
{
    /// <summary>
    /// Разнообразная конвертация
    /// </summary>
    class ClassConvert
    {
        /// <summary>
        /// Конвертация изображения в base64
        /// </summary>
        /// <param name="FileName">Имя файла изображения</param>
        /// <returns>Изображение в base64</returns>
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

        /// <summary>
        /// Конвертация изображения из bse64 в Image
        /// </summary>
        /// <param name="Base64String">строка-изображение в base64</param>
        /// <returns>Image</returns>
        static public Image ConvertBase64ToImage(string Base64String)
        {
            Bitmap bm2;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Base64String)))
            {
                bm2 = new Bitmap(ms);

            }
            return bm2;
        }

        /// <summary>
        /// Получение строки ключевых слов
        /// </summary>
        /// <param name="vs">Список ключевых слов</param>
        /// <returns>Строка ключевых слов, разделенных запятыми</returns>
        static public string getKeyString(List<string> vs)
        {
            string Text = "";
            foreach (string s in vs)
                Text += s + ", ";
            return Text;
        }

        /// <summary>
        /// Получения списка ключевых слов из строки
        /// </summary>
        /// <param name="Keys">Строка ключевых слов, разделенных запятыми</param>
        /// <returns>Список ключевых фраз</returns>
        static public List<string> getKeysList(string Keys)
        {

            string[] str = Keys.Split(new char[] { ',', '\n' });
            List<string> keyWords = new List<string>();
            foreach (string s in str)
               keyWords.Add(s.Trim());
            int count = keyWords.Where(e => e == "").Count();
            for (int i = 0; i < count; i++)
                keyWords.Remove("");
            return keyWords;
        }
    }
}
