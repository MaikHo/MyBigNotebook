using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigNotebook
{
    /// <summary>
    /// Дневник
    /// </summary>
    class ClassDiary:ICrypt
    {
        /// <summary>
        /// Записи в дневнике
        /// </summary>
        public List<DiaryRec> DiaryRecs;
        public ClassDiary()
        {
            DiaryRecs = new List<DiaryRec>();
        }
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {

              //  ClassCrypt.Decrypt(DiaryRecs.ToArray());
              // списком как-то не передавалось, а так врятли работает, постом посмотреть.
                foreach (DiaryRec rec in DiaryRecs)
                    rec.Decrypt();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns></returns>
        public bool Encrypt()
        {
            try
            {
                foreach (DiaryRec rec in DiaryRecs)
                    rec.Encrypt();
                return true;
            }
            catch { return false; }
        }


    }

    /// <summary>
    /// Запись в дневник
    /// </summary>
    [Serializable]
    class DiaryRec:ICrypt
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date;
        /// <summary>
        /// Запись
        /// </summary>
        public string Text;

        public DiaryRec()
        {
            Date = DateTime.Now;
            Text = "";
        }
        public bool Decrypt()
        {
            try
            {               
                Text = ClassCrypt.Decrypt(Text);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Text = ClassCrypt.Encrypt(Text);
                return true;
            }
            catch { return false; }
        }
    }
}
