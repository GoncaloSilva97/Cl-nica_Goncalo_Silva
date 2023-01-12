using Clínica_Goncalo_Silva_CET68.Classes;
using Clínica_Goncalo_Silva_CET68.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clínica_Goncalo_Silva_CET68
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            DataClasses1DataContext dc = new DataClasses1DataContext();
        }
    }
}
