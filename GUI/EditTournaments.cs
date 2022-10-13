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
    public partial class EditTournaments : Form
    {
        public EditTournaments()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddTournament tournament=new AddTournament();
            tournament.ShowDialog();
            bindData();
        }

        private void bindData()
        {
            dataGridView1.DataSource =null;
            dataGridView1.DataSource = TournamenDL.Tour;
            dataGridView1.Refresh();
        }

        private void EditTournaments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TournamenDL.Tour;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tournament tour = dataGridView1.SelectedRows[0].DataBoundItem as tournament;
            EditTournament.Tournament=tour;
            EditTournament tournament = new EditTournament();
            tournament.ShowDialog();
            bindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tournament tour = dataGridView1.SelectedRows[0].DataBoundItem as tournament;
            DeleteTournament.Tournament = tour;
            DeleteTournament deleteTournament=new DeleteTournament();
            deleteTournament.ShowDialog();
            bindData();

        }
    }
}
