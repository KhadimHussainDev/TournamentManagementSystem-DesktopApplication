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
    public partial class Tournaments : Form
    {
        public Tournaments()
        {
            InitializeComponent();
        }

        private void Tournaments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TournamenDL.Tour;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
