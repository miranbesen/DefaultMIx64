using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapInfo.Application;

namespace DefaultMIx64
{
    static class Program
    {
        
        public static MainForm mainForm;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string lpPathName);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetDllDirectory(@"C:\Program Files\MapInfo\Professional\");

            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
