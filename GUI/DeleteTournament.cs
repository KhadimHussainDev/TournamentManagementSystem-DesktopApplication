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
    public partial class DeleteTournament : Form
    {
        private static tournament tournament;
        internal static tournament Tournament { get => tournament; set => tournament = value; }
        public DeleteTournament()
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

        private void DeleteTournament_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TournamenDL.deleteTournament(Tournament);
            TournamenDL.storeTournamentInFile();
            Close();
        }
    }
}
