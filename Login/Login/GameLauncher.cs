namespace EragonStructure
{
    using System.Windows.Forms;
    using EragonStructure.UI;

    public class GameLauncher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}