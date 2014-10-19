using System.Windows.Forms;
using EragonStructure.UI;

namespace EragonStructure
{
    public class GameLauncher v
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
