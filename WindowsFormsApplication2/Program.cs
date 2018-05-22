/// </summary>
/// Project :        Matching Game
/// Class :          Program
/// Author :         Nick Bruno and Chris Kane
/// Description :    The main entry point for the application.
/// </summary>

using System;
using System.Windows.Forms;

namespace matchingGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Options());
        }
    }
}
