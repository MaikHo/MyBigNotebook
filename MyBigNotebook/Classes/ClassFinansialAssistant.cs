using System;
using System.Collections.Generic;


namespace MyBigNotebook
{

    /// <summary>
    /// Финансовый помощник
    /// </summary>
    public class ClassFinansialAssistant:ICrypt
    {
        /// <summary>
        /// Траты
        /// </summary>
        public List<Expenses> Expensess;
        /// <summary>
        /// Доходы
        /// </summary>
        public List<Profit> Profits;
        /// <summary>
        /// Накопления
        /// </summary>
        public List<CashSaving> CashSavings;
        /// <summary>
        /// Долги
        /// </summary>
        public List<Debt> Debts;

        public ClassFinansialAssistant()
        {
            Expensess = new List<Expenses>();
            Profits = new List<Profit>();
            CashSavings = new List<CashSaving>();
            Debts = new List<Debt>();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (Expenses expenses in Expensess)
                    expenses.Decrypt();
                foreach (Profit profit in Profits)
                    profit.Decrypt();
                foreach (CashSaving cash in CashSavings)
                    cash.Decrypt();
                foreach (Debt debt in Debts)
                    debt.Decrypt();
                
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
                foreach (Expenses expenses in Expensess)
                    expenses.Encrypt();
                foreach (Profit profit in Profits)
                    profit.Encrypt();
                foreach (CashSaving cash in CashSavings)
                    cash.Encrypt();
                foreach (Debt debt in Debts)
                    debt.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Расходы
    /// </summary>
    [Serializable]
    public class Expenses :ICrypt
    {
        /// <summary>
        /// Сумма
        /// </summary>
        public double Summ;
        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency;
        /// <summary>
        /// Категория
        /// </summary>
        public string Category;
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date;
        /// <summary>
        /// Периодичность
        /// </summary>
        public bool IsPeriodic;

        public Expenses()
        {
            Summ = 0;
            Currency = "";
            Category = "";
            Name = "";
            Date = DateTime.Now;
            IsPeriodic = false;
        }
        public virtual  bool  Decrypt()
        {
            try
            {
                Currency = ClassCrypt.Decrypt(Currency);
                Category = ClassCrypt.Decrypt(Category);
                Name = ClassCrypt.Decrypt(Name);
                return true;
            }
            catch { return false; }
        }

        public virtual bool Encrypt()
        {
            try
            {
                Currency = ClassCrypt.Encrypt(Currency);
                Category = ClassCrypt.Encrypt(Category);
                Name = ClassCrypt.Encrypt(Name);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Доходы
    /// </summary>
    [Serializable]
    public class Profit :Expenses
    {
        /// <summary>
        /// Источник
        /// </summary>
        public string Source;

        public Profit():base()
        {
            Source = "";
        }

        public override bool  Decrypt()
        {
            try
            {
                Source = ClassCrypt.Decrypt(Source);
                base.Decrypt();
                return true;
            }
            catch { return false; }
        }
        public override bool Encrypt()
        {
            try
            {
                Source = ClassCrypt.Encrypt(Source);
                base.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// накопления
    /// </summary>
    [Serializable]
    public class CashSaving :ICrypt
    {
        /// <summary>
        /// Сумма
        /// </summary>
        public double Summ;
        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency;
        /// <summary>
        /// Дата поступления
        /// </summary>
        public DateTime Date;
        /// <summary>
        /// Место хранения
        /// </summary>
        public string Storage;

        public CashSaving()
        {
            Summ = 0;
            Currency = "";
            Date = DateTime.Now;
            Storage = "";
        }
        public bool Decrypt()
        {
            try
            {
                Currency = ClassCrypt.Decrypt(Currency);
                Storage = ClassCrypt.Decrypt(Storage);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Currency = ClassCrypt.Encrypt(Currency);
                Storage = ClassCrypt.Encrypt(Storage);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Долги
    /// </summary>
    [Serializable]
    public class Debt :ICrypt
    {
        /// <summary>
        /// Кому должен
        /// </summary>
        public string Debtor;
        /// <summary>
        /// Кто должен
        /// </summary>
        public string Creditor;
        /// <summary>
        /// Сумма
        /// </summary>
        public double Summ;
        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency;
        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime ReturnDate;
        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime IssueDate;
        /// <summary>
        /// Отдан ли
        /// </summary>
        public bool IsReturned;

        public Debt()
        {
            Debtor = "";
            Creditor = "";
            Currency = "";
            Summ = 0;
            ReturnDate = DateTime.Now;
            IssueDate = DateTime.Now;
            IsReturned = false;
        }

        public bool Decrypt()
        {
            try
            {
                Currency = ClassCrypt.Decrypt(Currency);
                Creditor = ClassCrypt.Decrypt(Creditor);
                Debtor = ClassCrypt.Decrypt(Debtor);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Currency = ClassCrypt.Encrypt(Currency);
                Creditor = ClassCrypt.Encrypt(Creditor);
                Debtor = ClassCrypt.Encrypt(Debtor);
                return true;
            }
            catch { return false; }
        }
    }

}
