using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;
using System.Drawing.Imaging;

namespace MyBigNotebook
{
    [Serializable]
    public class ClassData:ICrypt
    {
        /// <summary>
        /// Календарь
        /// </summary>
        public ClassCalendar calendar;
        /// <summary>
        /// Дневник
        /// </summary>
        public ClassDiary diary;
        /// <summary>
        /// Финансовый помошник
        /// </summary>
        public ClassFinansialAssistant finansialAssistant;
        /// <summary>
        /// Информация
        /// </summary>
        public ClassInformation information;
        /// <summary>
        /// Заметки
        /// </summary>
        public ClassNotes notes;
        /// <summary>
        /// Фото
        /// </summary>
        public ClassPhoto photo;
        /// <summary>
        /// Планы
        /// </summary>
        public ClassPlants plants;
        /// <summary>
        /// Распорядок дня
        /// </summary>
        public ClassRoutineDay routineDay;

        public ClassData()
        {
            calendar = new ClassCalendar();
            diary = new ClassDiary();
            finansialAssistant = new ClassFinansialAssistant();
            information = new ClassInformation();
            notes = new ClassNotes();
            photo = new ClassPhoto();
            plants = new ClassPlants();
            routineDay = new ClassRoutineDay();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns></returns>
        public bool Decrypt()
        {
            try
            {
                calendar.Decrypt();
                diary.Decrypt();
                finansialAssistant.Decrypt();
                information.Decrypt();
                notes.Decrypt();
                photo.Decrypt();
                plants.Decrypt();
                routineDay.Decrypt();
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
                calendar.Encrypt();
                diary.Encrypt();
                finansialAssistant.Encrypt();
                information.Encrypt();
                notes.Encrypt();
                photo.Encrypt();
                plants.Encrypt();
                routineDay.Encrypt();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Чтение данных
        /// </summary>
        public void LoadData()
        {
            try
            {
                //Отчего-то фишка как с сериализацией не прокатила(хотя в потоке все нормально)
                //так что костыли - наше все
                XmlSerializer formatter = new XmlSerializer(typeof(ClassData));
                GoogleDriveClass driveClass = new GoogleDriveClass();
                driveClass.Authorize();

                MemoryStream stream = driveClass.FileRead(driveClass.GetFileId("Data.txt"));
                FileStream file = new FileStream("TempData.xml", FileMode.OpenOrCreate);
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(file);
                file.Close();

                using (FileStream fs = new FileStream("TempData.xml", FileMode.OpenOrCreate))
                //using (XmlWriter xmlWriter = new XmlTextWriter(fs, Encoding.UTF8))
                {

                    ClassData classData = (ClassData)formatter.Deserialize(fs);
                    this.calendar = classData.calendar;
                    this.diary = classData.diary;
                    this.finansialAssistant = classData.finansialAssistant;
                    this.information = classData.information;
                    this.notes = classData.notes;
                    this.photo = classData.photo;
                    this.plants = classData.plants;
                    this.routineDay = classData.routineDay;
                }
                File.Delete("TempData.xml");
            } catch { }
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        public void SaveData()
        {          
            XmlSerializer formatter = new XmlSerializer(typeof(ClassData));
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, this);
            GoogleDriveClass driveClass = new GoogleDriveClass();
            driveClass.Authorize();
            driveClass.FileUpdate("Data.txt", stream);

            //using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            //using (XmlWriter xmlWriter = new XmlTextWriter(fs, Encoding.UTF8))
            //{
            //    formatter.Serialize(fs, this);
            //}
        }

       


    }
}
