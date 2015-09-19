using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsForms_practice.MVCPrac;
using WindowsForms_practice.MVCTest;
using WindowsForms_practice.MVCTest2;
using WindowsForms_practice.MVCTest3;
using WindowsForms_practice.Thread1;
using WindowsForms_practice.HK;
using System.IO;
using System.Threading;


namespace WindowsForms_practice
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
            Application.Run(new HKForm());
        }
    }
}
