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
    public partial class EditSchedule : Form
    {
        public EditSchedule()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule=new AddSchedule();
            addSchedule.ShowDialog();
            bindData();
        }

        private void bindData()
        {
            dataGridView1.DataSource =null;
            dataGridView1.DataSource = scheduleDL.Scheduled;
            dataGridView1.Columns["Time"].Visible = false;
            dataGridView1.Refresh();
        }

        private void EditSchedule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = scheduleDL.Scheduled;
            dataGridView1.Columns["Time"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedule schedule = dataGridView1.SelectedRows[0].DataBoundItem as schedule;
            EditScheduledMatch.Schedule = schedule;
            EditScheduledMatch editScheduledMatch=new EditScheduledMatch();
            editScheduledMatch.ShowDialog();
            bindData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedule schedule = dataGridView1.SelectedRows[0].DataBoundItem as schedule;
            DeleteSchedule.Schedule = schedule;
            DeleteSchedule deleteSchedule=new DeleteSchedule();
            deleteSchedule.ShowDialog();
            bindData();
        }
    }
}
