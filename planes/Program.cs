using System;
using System.Windows.Forms;

namespace planes
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
         
            GUI fmGUI = new GUI();
            fmGUI.GameMechanics = new GameMechanics(); 
            Application.Run(fmGUI);   
        }
    }
}
