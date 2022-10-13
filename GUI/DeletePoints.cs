using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DL;
namespace TournamentManegmentSystemDesktopApplication.GUI
{
    public partial class DeletePoints : Form
    {
        private static teams team;

        internal static teams Team { get => team; set => team = value; }

        public DeletePoints()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            team.TotalPlayedMatches = 0;
            team.WonMatches = 0;
            team.LostMatches = 0;
            team.Points = 0;



            teamsDL.storeTeamsInFile();
            MessageBox.Show("Point Table Updated Successfully");
            this.Close();
        }
    }
}
