using System;
using System.Collections.Generic;

namespace MyBigNotebook
{
    /// <summary>
    /// Календарь
    /// </summary>
    [Serializable]
    class ClassCalendar:ICrypt
    {
        /// <summary>
        /// Дни рождения
        /// </summary>
        List<BirthDay> BirthDays;
        /// <summary>
        /// Памятные даты
        /// </summary>
        List<MemorableDate> MemorableDates;
        /// <summary>
        /// Напоминания
        /// </summary>
        List<Reminder> Reminders;

        public ClassCalendar()
        {
            BirthDays = new List<BirthDay>();
            MemorableDates = new List<MemorableDate>();
            Reminders = new List<Reminder>();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (BirthDay birth in BirthDays)
                    birth.Decrypt();
                foreach (MemorableDate memorable in MemorableDates)
                    memorable.Decrypt();
                foreach (Reminder reminder in Reminders)
                    reminder.Decrypt();
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
                foreach (BirthDay birth in BirthDays)
                    birth.Encrypt();
                foreach (MemorableDate memorable in MemorableDates)
                    memorable.Encrypt();
                foreach (Reminder reminder in Reminders)
                    reminder.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// День рождения
    /// </summary>
    [Serializable]
    class BirthDay:ICrypt
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO;
        /// <summary>
        /// дата
        /// </summary>
        public DateTime Date;

        public BirthDay()
        {
            FIO = "";
            Date = DateTime.Now;
        }
        public bool Decrypt()
        {
            try
            {
                FIO = ClassCrypt.Decrypt(FIO);                          
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                FIO = ClassCrypt.Encrypt(FIO);                    
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// памятная дата
    /// </summary>
    [Serializable]
    class MemorableDate:ICrypt
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date;
        /// <summary>
        /// Отметка о напоминании
        /// </summary>
        public bool Promt;

        public MemorableDate()
        {
            Name = "";
            Description = "";
            Date = DateTime.Now;
            Promt = false;
        }
        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                Description = ClassCrypt.Decrypt(Description);
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
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// напоминания
    /// </summary>
    [Serializable]
    class Reminder
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Текст
        /// </summary>
        public string Text;
        /// <summary>
        /// Дата и время
        /// </summary>
        public DateTime Time;

        public Reminder()
        {
            Name = "";
            Text = "";
            Time = DateTime.Now;
        }

        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                Text = ClassCrypt.Decrypt(Text);
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
                return true;
            }
            catch { return false; }
        }


    }

}
