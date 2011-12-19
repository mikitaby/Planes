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
            
            MessageBox.Show(RadianToDegree.ToDegree(57).ToString());
            MessageBox.Show(RadianToDegree.ToDegree(-1.1).ToString());
            MessageBox.Show(RadianToDegree.ToDegree(21.1).ToString());

            RandomParams randomParams = new RandomParams();
            
            GUI fmGUI = new GUI();
            fmGUI.GameMechanics = new GameMechanics(); 

            Application.Run(fmGUI);   
        }
    }
}
