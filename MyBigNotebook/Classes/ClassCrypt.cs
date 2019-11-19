using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace MyBigNotebook
{
  static  class ClassCrypt
    {
        /// <summary>
        /// ключ
        /// </summary>
        static private string password = "JGT863_sdfkJKd2546s4+sf64sf4sefs+asef+fwf+wf5t6hdslg4535-sgert";

        /// <summary>
        /// Смена ключа шифрования
        /// </summary>
        /// <param name="NewKey"></param>
        static public void SetKey(string NewKey)
        {
            password = NewKey;
        }



        static private byte[] Encrypt(byte[] data)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateEncryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }

        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="data">Строка, которую необходимо зашифровать</param>
        /// <returns>Зашифрованная строка</returns>
        public static string Encrypt(string data)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(data)));
        }

        private static byte[] Decrypt(byte[] data)
        {
            BinaryReader br = new BinaryReader(InternalDecrypt(data));
            return br.ReadBytes(data.Length);
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="data">Шифрованная строка</param>
        /// <returns>Дешифрованная строка</returns>
        public static string Decrypt(string data)
        {
            CryptoStream cs = InternalDecrypt(Convert.FromBase64String(data));
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        static CryptoStream InternalDecrypt(byte[] data)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream(data);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }

        /// <summary>
        /// Шифрование списка
        /// </summary>
        /// <param name="crypts">Список объектов с интерфейсом ICrypt</param>
        public static void Encrypt(ICrypt[] crypts)
        {
            foreach (ICrypt crypt in crypts)
                crypt.Encrypt();
        }

        /// <summary>
        /// Дешифрование списка
        /// </summary>
        /// <param name="crypts">Список объектов с интерфейсом ICrypt</param>
        public static void Decrypt(ICrypt[] crypts)
        {
            foreach (ICrypt crypt in crypts)
                crypt.Decrypt();
        }


    }

    /// <summary>
    /// Интерфейс для шифрования полей и классов
    /// </summary>
    interface ICrypt
    {       
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns>True, если удачно</returns>
        bool Decrypt();
        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns>True, если удачно</returns>
        bool Encrypt();

    }
}
