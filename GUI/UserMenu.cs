using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManegmentSystemDesktopApplication.GUI
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignIN signIN = new SignIN();   
            signIN.ShowDialog();
           // Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllTeams allTeams=new AllTeams();
            allTeams.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Schedule schedule=new Schedule();
            schedule.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointTable pointTable = new PointTable();
            pointTable.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tournaments tournaments=new Tournaments();
            tournaments.ShowDialog();
        }
    }
}
