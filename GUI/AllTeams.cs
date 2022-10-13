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
namespace TournamentManegmentSystemDesktopApplication.GUI
{
    public partial class AllTeams : Form
    {
        public AllTeams()
        {
            InitializeComponent();
        }

        private void AllTeams_Load(object sender, EventArgs e)
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
    }
}
