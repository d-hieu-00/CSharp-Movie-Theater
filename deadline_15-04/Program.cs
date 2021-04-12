using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadline_15_04
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyResources.Init();
            MyResources.ShowFormRapPhim();
            MyResources.MyRapPhim.Sample();

            Application.Run(MyResources.Form_RapPhim);
        }
    }
}
