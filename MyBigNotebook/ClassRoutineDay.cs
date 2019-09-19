using System;
using System.Collections.Generic;

namespace MyBigNotebook
{
    /// <summary>
    /// расписания
    /// </summary>
    class ClassRoutineDay:ICrypt
    {
        /// <summary>
        /// Список расписаний
        /// </summary>
        List<Shedule> Shedules;


        ClassRoutineDay()
        {
            Shedules = new List<Shedule>();
        }
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (Shedule shedule in Shedules)
                    shedule.Decrypt();
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
                foreach (Shedule shedule in Shedules)
                    shedule.Encrypt();
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Пункт расписания
    /// </summary>
    [Serializable]
    class ParagraphDay:ICrypt
    {
        /// <summary>
        /// Время начала
        /// </summary>
        public DateTime TimeStart;
        /// <summary>
        /// Время завершения
        /// </summary>
        public DateTime TimeEnd;
        /// <summary>
        /// Дело
        /// </summary>
        public string Work;

        public ParagraphDay()
        {
            TimeStart = DateTime.Now;
            TimeEnd = DateTime.Now;
            Work = "";
        }

        public bool Decrypt()
        {
            try
            {
                Work = ClassCrypt.Decrypt(Work);               
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Work = ClassCrypt.Encrypt(Work);
               
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Распорядок дня
    /// </summary>
    [Serializable]
    class StepSheduleDay:ICrypt
    {
        /// <summary>
        /// номер дня недели
        /// </summary>
        int WeekDay;
        /// <summary>
        /// Список пунктов
        /// </summary>
        List<ParagraphDay> ParagraphsInDay;

        public StepSheduleDay()
        {
            WeekDay = 0;
            ParagraphsInDay = new List<ParagraphDay>();
        }
        public bool Decrypt()
        {
            try
            {
                foreach (ParagraphDay day in ParagraphsInDay)
                    day.Decrypt();
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                foreach (ParagraphDay day in ParagraphsInDay)
                    day.Encrypt();

                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Расписание на период
    /// </summary>
    [Serializable]
    class Shedule:ICrypt
    {
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime DateStart;
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime DateEnd;
        /// <summary>
        /// Расписание по дням недели
        /// </summary>
        public List<StepSheduleDay> SheduleDays;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;

        public Shedule()
        {
            DateStart = DateTime.Now;
            DateEnd = DateTime.Now;
            SheduleDays = new List<StepSheduleDay>();
            Description = "";
        }

        public bool Decrypt()
        {
            try
            {
                Description = ClassCrypt.Decrypt(Description);
                foreach (StepSheduleDay day in SheduleDays)
                    day.Decrypt();
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                foreach (StepSheduleDay day in SheduleDays)
                    day.Encrypt();
                Description = ClassCrypt.Encrypt(Description);
                return true;
            }
            catch { return false; }
        }
    }

}
