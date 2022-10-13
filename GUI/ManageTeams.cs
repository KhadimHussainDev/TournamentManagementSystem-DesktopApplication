using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL;
using BL;
namespace TournamentManegmentSystemDesktopApplication.GUI
{
    public partial class ManageTeams : Form
    {
        public ManageTeams()
        {
            InitializeComponent();
        }

        private void ManageTeams_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamsDL.Team;
            dataGridView1.Columns["CaptainAge"].Visible = false;
            dataGridView1.Columns["ViceCaptainAge"].Visible = false;
            dataGridView1.Columns["TotalPlayedMatches"].Visible = false;
            dataGridView1.Columns["WonMatches"].Visible = false;
            dataGridView1.Columns["LostMatches"].Visible = false;
            dataGridView1.Columns["Points"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTeam team=new AddTeam();
            team.ShowDialog();
            bindData();
        }

        private void bindData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=teamsDL.Team;
            dataGridView1.Columns["CaptainAge"].Visible = false;
            dataGridView1.Columns["ViceCaptainAge"].Visible = false;
            dataGridView1.Columns["TotalPlayedMatches"].Visible = false;
            dataGridView1.Columns["WonMatches"].Visible = false;
            dataGridView1.Columns["LostMatches"].Visible = false;
            dataGridView1.Columns["Points"].Visible = false;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            teams team =dataGridView1.SelectedRows[0].DataBoundItem as teams;
            EditTeam.Team=team;
            EditTeam editTeam=new EditTeam();
            editTeam.ShowDialog();
            bindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teams team = dataGridView1.SelectedRows[0].DataBoundItem as teams;
            DeleteTeam teamDel=new DeleteTeam();
            DeleteTeam.Team = team;
            teamDel.ShowDialog();
            bindData();



        }
    }
}
