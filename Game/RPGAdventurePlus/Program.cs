using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Engine;
using RPGAdventurePlus.View_Layer;

namespace RPGAdventurePlus
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
            frm_MainMenu mainMenu = new frm_MainMenu();
            mainMenu.Show();

            Application.Run();
        }
    }
}
