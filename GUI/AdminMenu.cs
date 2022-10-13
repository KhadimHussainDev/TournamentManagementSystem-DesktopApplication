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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllTeams allTeams = new AllTeams();
            allTeams.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tournaments tournaments = new Tournaments();
            tournaments.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointTable pointTable = new PointTable();
            pointTable.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageTeams manageTeams = new ManageTeams();
            manageTeams.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditSchedule schedule = new EditSchedule();
            schedule.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EditTournaments tournaments = new EditTournaments();
            tournaments.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword=new ChangePassword();
            changePassword.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Are Logged Out.");
            this.Hide();
            UserMenu userMenu=new UserMenu();
            userMenu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditPointTable editPointTable=new EditPointTable();
            editPointTable.ShowDialog();
        }
    }
}
