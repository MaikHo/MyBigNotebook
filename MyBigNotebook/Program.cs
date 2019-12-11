using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyBigNotebook
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            using (var mutex = new Mutex(false, "MyBigNotebookMutex"))
            {
                if (mutex.WaitOne(TimeSpan.FromSeconds(3))) // Подождать три секунды - вдруг предыдущий экземпляр еще закрывается
                    Application.Run(new FormMain());
                else
                    MessageBox.Show("Одна копия приложения уже запущена", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
