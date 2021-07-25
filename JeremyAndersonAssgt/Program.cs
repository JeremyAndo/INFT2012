//INFT2012 INDIVIDUAL ASSIGNMENT
//JEREMY ANDERSON c3315176
//Date - 29/05/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeremyAndersonAssgt
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
            Application.Run(new frmGameType());
        }
    }
}
