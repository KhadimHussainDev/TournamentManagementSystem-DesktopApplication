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
    public partial class EditPointTable : Form
    {
        public EditPointTable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void EditPointTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamsDL.Team;
            dataGridView1.Columns["CaptainAge"].Visible = false;
            dataGridView1.Columns["ViceCaptainAge"].Visible = false;
            dataGridView1.Columns["CaptainName"].Visible = false;
            dataGridView1.Columns["ViceCaptainName"].Visible = false;
            dataGridView1.Columns["OwnerName"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teams team = dataGridView1.SelectedRows[0].DataBoundItem as teams;
            EditPoints.Team = team;
            EditPoints editTeam = new EditPoints();
            editTeam.ShowDialog();
            bindData();
        }
        private void bindData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = teamsDL.Team;
            dataGridView1.Columns["CaptainAge"].Visible = false;
            dataGridView1.Columns["ViceCaptainAge"].Visible = false;
            dataGridView1.Columns["CaptainName"].Visible = false;
            dataGridView1.Columns["ViceCaptainName"].Visible = false;
            dataGridView1.Columns["OwnerName"].Visible = false;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            teams team = dataGridView1.SelectedRows[0].DataBoundItem as teams;
            DeletePoints.Team = team;
            DeletePoints deletePoints=new DeletePoints();
            deletePoints.ShowDialog();
            bindData();
        }
    }
}
