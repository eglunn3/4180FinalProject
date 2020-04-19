using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Analyzer_App
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
            MainMenu mainMenu = new MainMenu();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.AutoSize = true;
            Application.Run(mainMenu);
            
        }
 
    }
}
