using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_kadrowy
{
    static class Program
    {
        public static EmpList EmpListAddr = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EmpListAddr = new EmpList();

            Application.Run(EmpListAddr);
        }
    }
}
