using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1_kriptoanalizCaesar
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
            Coder c = new Coder();
            c.CreateFrequancyTable();
            FileHandler f = new FileHandler();
            Application.Run(new StartForm(c,f));
        }
    }
}
