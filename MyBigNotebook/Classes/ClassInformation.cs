using System;
using System.Collections.Generic;

namespace MyBigNotebook
{
    /// <summary>
    /// Информация разнообразная
    /// </summary>
    public class ClassInformation :ICrypt
    {
        /// <summary>
        /// Личные дела
        /// </summary>
        public List<Dossier> Dossiers;
        /// <summary>
        /// Полезная информация
        /// </summary>
        public List<HelpfullInformation> HelpfullsInfo;
        /// <summary>
        /// Полезные ссылки
        /// </summary>
        public List<HelpfullLink> HelpfullLinks;

        public ClassInformation()
        {
            Dossiers = new List<Dossier>();
            HelpfullLinks = new List<HelpfullLink>();
            HelpfullsInfo = new List<HelpfullInformation>();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                foreach (Dossier dossier in Dossiers)
                    dossier.Decrypt();
                foreach (HelpfullInformation helpfull in HelpfullsInfo)
                    helpfull.Decrypt();
                foreach (HelpfullLink helpfullLink in HelpfullLinks)
                    helpfullLink.Decrypt();
               

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
                foreach (Dossier dossier in Dossiers)
                    dossier.Encrypt();
                foreach (HelpfullInformation helpfull in HelpfullsInfo)
                    helpfull.Encrypt();
                foreach (HelpfullLink helpfullLink in HelpfullLinks)
                    helpfullLink.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Контакт
    /// </summary>
    [Serializable]
    public class Kontact :ICrypt
    {
        /// <summary>
        /// Система(телефон, сайт, месседжер)
        /// </summary>
        public string System;
        /// <summary>
        /// Номер/ссылка на профиль
        /// </summary>
        public string Number;

        public Kontact()
        {
            System = "";
            Number = "";
        }

        public bool Decrypt()
        {
            try
            {
                System = ClassCrypt.Decrypt(System);
                Number = ClassCrypt.Decrypt(Number);
                
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                System = ClassCrypt.Encrypt(System);
                Number = ClassCrypt.Encrypt(Number);              
                return true;
            }
            catch { return false; }
        }
    }

    [Serializable]
    public class Dossier : ICrypt
    {
        public string Name;
        public string LastName;
        public string SurName;
        public DateTime BirthDay;
        public string Interests;
        public string Description;
        public List<string> Photos;
        public List<Kontact> Kontacts;
        public string AdditionalInformation;
        public string FamilyStatus;
        public string EducationLevel;
        public string EducatonLocationAndSpec;
        public string WorkPlace;
        public string WorkPosition;

        public Dossier()
        {
            Name = "";
            LastName = "";
            SurName = "";
            BirthDay = DateTime.MinValue;
            Interests = "";
            Description = "";
            Photos = new List<string>();
            Kontacts = new List<Kontact>();
            AdditionalInformation = "";
            FamilyStatus = "";
            EducationLevel = "";
            EducatonLocationAndSpec = "";
            WorkPlace = "";
            WorkPosition = "";
        }

        public bool Decrypt()
        {
            try
            {
                Name = ClassCrypt.Decrypt(Name);
                LastName = ClassCrypt.Decrypt(LastName);
                SurName = ClassCrypt.Decrypt(SurName);
                Interests = ClassCrypt.Decrypt(Interests);
                Description = ClassCrypt.Decrypt(Description);
                foreach (Kontact kontact in Kontacts)
                    kontact.Decrypt();
                AdditionalInformation = ClassCrypt.Decrypt(AdditionalInformation);
                FamilyStatus = ClassCrypt.Decrypt(FamilyStatus);
                EducationLevel = ClassCrypt.Decrypt(EducationLevel);
                EducatonLocationAndSpec = ClassCrypt.Decrypt(EducatonLocationAndSpec);
                WorkPlace = ClassCrypt.Decrypt(WorkPlace);
                WorkPosition = ClassCrypt.Decrypt(WorkPosition);
                return true;
            }
            catch { return false; }
        }

        public bool Encrypt()
        {
            try
            {
                Name = ClassCrypt.Encrypt(Name);
                LastName = ClassCrypt.Encrypt(LastName);
                SurName = ClassCrypt.Encrypt(SurName);
                Interests = ClassCrypt.Encrypt(Interests);
                Description = ClassCrypt.Encrypt(Description);
                foreach (Kontact kontact in Kontacts)
                    kontact.Encrypt();
                AdditionalInformation = ClassCrypt.Encrypt(AdditionalInformation);
                FamilyStatus = ClassCrypt.Encrypt(FamilyStatus);
                EducationLevel = ClassCrypt.Encrypt(EducationLevel);
                EducatonLocationAndSpec = ClassCrypt.Encrypt(EducatonLocationAndSpec);
                WorkPlace = ClassCrypt.Encrypt(WorkPlace);
                WorkPosition = ClassCrypt.Encrypt(WorkPosition);

                return true;
            }
            catch { return false; }
        }
    }

        /// <summary>
        /// Полезная информация
        /// </summary>
        [Serializable]
    public class HelpfullInformation :Idea
        {
            public HelpfullInformation():base()
            {
                
            }
        }

        /// <summary>
        /// Полезные ссылки
        /// </summary>
        [Serializable]
    public class HelpfullLink :ICrypt
        {
            /// <summary>
            /// Название
            /// </summary>
            public string Name;
            /// <summary>
            /// Ссылка
            /// </summary>
            public string Link;
            /// <summary>
            /// Описание
            /// </summary>
            public string Description;

            public HelpfullLink()
            {
                Name = "";
                Link = "";
                Description = "";
            }
            public bool Decrypt()
            {
                try
                {
                    Name = ClassCrypt.Decrypt(Name);
                    Link = ClassCrypt.Decrypt(Link);
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
                    Link = ClassCrypt.Encrypt(Link);
                    Description = ClassCrypt.Encrypt(Description);
                    return true;
                }
                catch { return false; }
            }

        

        }
}
