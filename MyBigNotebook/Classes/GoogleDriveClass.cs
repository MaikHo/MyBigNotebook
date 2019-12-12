using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Configuration;




namespace MyBigNotebook
{
    /// <summary>
    /// Класс для работы с гугл диском
    /// </summary>
    class GoogleDriveClass
    {
        static string[] Scopes = { DriveService.Scope.DriveFile };  //Массив для работы с файлами
        static string ApplicationName = "MyBigNotebook";      //Наименование программы
        public static UserCredential credential = null;             //Ключи авторизации

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <returns></returns>
        public bool Authorize()
        {
          
            using (System.IO.FileStream stream =
                     new System.IO.FileStream(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"/Client.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                try
                {
                    string credPath = System.Environment.CurrentDirectory.ToString();
                    credPath = System.IO.Path.Combine(credPath, "Google");
                    
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        GoogleDriveClass.Scopes,
                        ConfigurationManager.AppSettings.Get("GoogleUser"), CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;

                }
                catch (Exception)
                {                   
                    credential = null;
                }

            }
            return (credential != null);
        }

        /// <summary>
        /// Создание нового файла
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="value">Поток данных для записи</param>
        /// <param name="id">Ид созданного файла</param>
        /// <returns></returns>
        public bool FileCreate(string name, MemoryStream value, out string id)
        {
            bool result = false;
            id = null;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }

            using (var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))

            {
                var body = new Google.Apis.Drive.v3.Data.File();
                body.Name = name;
                body.MimeType = "text/json";
                body.ViewersCanCopyContent = true;

                //byte[] byteArray = Encoding.Default.GetBytes(value);
                //using (var stream = new System.IO.MemoryStream(byteArray))
                //{
                    Google.Apis.Drive.v3.FilesResource.CreateMediaUpload request = service.Files.Create(body, value, body.MimeType);
                    if (request.Upload().Exception == null)
                    { id = request.ResponseBody.Id; result = true; }
                //}
            }
            return result;
        }

        /// <summary>
        /// Обновление файла
        /// </summary>
        /// <param name="name">Имя файла</param>
        /// <param name="value">Записываемый поток</param>
        /// <returns></returns>
        public bool FileUpdate(string name, MemoryStream value)
        {
            bool result = false;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }

            string new_id;
            if (FileCreate(name, value, out new_id))
            {
                IList<Google.Apis.Drive.v3.Data.File> files = GetFileList();
                if (files != null && files.Count > 0)
                {
                    result = true;
                    try
                    {
                        using (var service = new DriveService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = ApplicationName,
                        }))
                        {
                            foreach (var file in files)
                            {
                                if (file.Name == name && file.Id != new_id)
                                {
                                    try
                                    {
                                        Google.Apis.Drive.v3.FilesResource.DeleteRequest request = service.Files.Delete(file.Id);
                                        string res = request.Execute();
                                    }
                                    catch (Exception)
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return result;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Получение списка файлов на гугл диске
        /// </summary>
        /// <returns>Имя файла</returns>
        public IList<Google.Apis.Drive.v3.Data.File> GetFileList()
        {
            IList<Google.Apis.Drive.v3.Data.File> result = null;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }
            // Create Drive API service.
            using (Google.Apis.Drive.v3.DriveService service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))
            {
                try
                {
                    // Define parameters of request.
                    FilesResource.ListRequest listRequest = service.Files.List();
                    listRequest.PageSize = 1000;
                    listRequest.Fields = "nextPageToken, files(id, name, size)";

                    // List files.
                    result = listRequest.Execute().Files;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return result;
        }
        /// <summary>
        /// Получение ид файла
        /// </summary>
        /// <param name="name">Имя файла</param>
        /// <returns>Гугл ИД файла</returns>
        public string GetFileId(string name)
        {
            string result = null;
            IList<Google.Apis.Drive.v3.Data.File> files = GetFileList();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == name)
                    {
                        result = file.Id;
                        break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Чтение файла из google drive в поток
        /// </summary>
        /// <param name="id">ид файла</param>
        /// <returns>Поток</returns>
        public MemoryStream FileRead(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return null;
            }
            
            if (credential == null)
                this.Authorize();
            if (credential != null)
            {
                using (var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                }))
                {
                    Google.Apis.Drive.v3.FilesResource.GetRequest request = service.Files.Get(id);
                    MemoryStream stream = new MemoryStream();
                    
                        request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
                        {
                            if (progress.Status == Google.Apis.Download.DownloadStatus.Completed) { }
                               
                        };
                        request.Download(stream);

                        //if (result)
                        //{
                        //    //int start = 0;
                        //    //int count = (int)stream.Length;
                        //    //value = Encoding.Default.GetString(stream.GetBuffer(), start, count);
                        //}
                        return stream;
                    
                }
            }
            return null;
        }
    }

}
