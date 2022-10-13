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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = scheduleDL.Scheduled;
            dataGridView1.Columns["Time"].Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
