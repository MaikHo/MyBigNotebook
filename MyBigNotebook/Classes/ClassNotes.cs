using System;
using System.Collections.Generic;



namespace MyBigNotebook
{
    /// <summary>
    /// Записи
    /// </summary>
    [Serializable]
    public class ClassNotes :ICrypt
    {
        /// <summary>
        /// Пароли
        /// </summary>
        public List<Password> passwords;
        /// <summary>
        /// Идеи
        /// </summary>
        public List<Idea> ideas;
        /// <summary>
        /// записи
        /// </summary>
        public List<Record> records;

        public ClassNotes()
        {
            records = new List<Record>();
            ideas = new List<Idea>();
            passwords = new List<Password>();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (Password password in passwords)
                    password.Decrypt();
                foreach (Idea idea in ideas)
                    idea.Decrypt();
                foreach (Record record in records)
                    record.Decrypt();
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

                foreach (Password password in passwords)
                    password.Encrypt();
                foreach (Idea idea in ideas)
                    idea.Encrypt();
                foreach (Record record in records)
                    record.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Пароль
    /// </summary>
    [Serializable]
    public class Password :ICrypt
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Пароль
        /// </summary>
        public string Pass;
        /// <summary>
        /// Ссылка
        /// </summary>
        public string Link;
        /// <summary>
        /// Логин
        /// </summary>
        public string Login;
        public Password()
        {
            Name = "";
            Pass = "";
            Link = "";
            Login = "";
        }
        public Password(string name)
        {
            Name = name;
            Pass = "";
            Link = "";
            Login = "";
        }
        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                Pass = ClassCrypt.Decrypt(Pass);
                Link = ClassCrypt.Decrypt(Link);
                Login = ClassCrypt.Decrypt(Login);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Name = ClassCrypt.Encrypt(Name);
                Pass = ClassCrypt.Encrypt(Pass);
                Link = ClassCrypt.Encrypt(Link);
                Login = ClassCrypt.Encrypt(Login);
                return true;
            }
            catch { return false; }
        }

    }
   
    /// <summary>
    /// Идеи
    /// </summary>
    [Serializable]
    public class Idea :ICrypt
    {
        /// <summary>
        /// название
        /// </summary>
        public string Name;
        /// <summary>
        /// Текст
        /// </summary>
        public string Text;
        /// <summary>
        /// Ключевые слова
        /// </summary>
        public List<string> keyWords;

      public  Idea()
        {
            Name = "";
            Text = "";
            keyWords = new List<string>();
        }

        public Idea(string name)
        {
            Name = name;
            Text = "";
            keyWords = new List<string>();
        }
        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                Text = ClassCrypt.Decrypt(Text);
                for (int i = 0; i < keyWords.Count; i++)
                    keyWords[i] = ClassCrypt.Decrypt(keyWords[i]);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Name = ClassCrypt.Encrypt(Name);
                Text = ClassCrypt.Encrypt(Text);
                for (int i = 0; i < keyWords.Count; i++)
                    keyWords[i] = ClassCrypt.Encrypt(keyWords[i]);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Записи
    /// </summary>
    [Serializable]
    public class Record :Idea
    {
        public Record():base()
        {
            
        }
        public Record(string name):base(name)
        { }
    }



}
