using System;
using System.Collections.Generic;


namespace MyBigNotebook
{
    public class ClassPhoto :ICrypt
    {
        public List<Photograph> Photographs;

        public ClassPhoto()
        {
            Photographs = new List<Photograph>();
        }
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (Photograph photograph in Photographs)
                    photograph.Decrypt();
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
                foreach (Photograph photograph in Photographs)
                    photograph.Encrypt();

                return true;
            }
            catch { return false; }
        }


    }


    /// <summary>
    /// Фотография
    /// </summary>
    [Serializable]
    public class Photograph :ICrypt
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;
        /// <summary>
        /// Категория
        /// </summary>
        public string Category;
        /// <summary>
        /// Фото
        /// </summary>
        public string Photo;
        /// <summary>
        /// Ключевые слова
        /// </summary>
        public List<string> KeyWords;

        public Photograph()
        {
            Name = "";
            Description = "";
            Category = "";
            Photo = "";
            KeyWords = new List<string>();
        }

        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                Description = ClassCrypt.Decrypt(Description);
                Category = ClassCrypt.Decrypt(Category);
                              
                for (int i = 0; i < KeyWords.Count; i++)
                    KeyWords[i] = ClassCrypt.Decrypt(KeyWords[i]);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Name = ClassCrypt.Encrypt(Name);
                Description = ClassCrypt.Encrypt(Description);
                Category = ClassCrypt.Encrypt(Category);

                for (int i = 0; i < KeyWords.Count; i++)
                    KeyWords[i] = ClassCrypt.Encrypt(KeyWords[i]);

                return true;
            }
            catch { return false; }
        }


    }
}
