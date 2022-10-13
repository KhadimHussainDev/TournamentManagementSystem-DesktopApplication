using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentManegmentSystemDesktopApplication.GUI;
using BL;
using DL;
namespace TournamentManegmentSystemDesktopApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = "Password.txt";
            string path1 = "TeamInformation.txt";
            string path2 = "Tournament.txt";
            string path3 = "TeamSchedule.txt";

            if (passwordDL.loadPassword(path) &&scheduleDL.loadScheduleFromFile(path3) &&teamsDL.loadTeamsFromFile(path1) && TournamenDL.loadTournamentFromFile(path2))
            {
                MessageBox.Show("Loaded...");
            }
            Application.Run(new UserMenu());
        }
    }
}
