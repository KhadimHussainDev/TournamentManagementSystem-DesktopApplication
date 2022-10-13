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
    public partial class DeleteSchedule : Form
    {
        private static schedule schedule;

        internal static schedule Schedule { get => schedule; set => schedule = value; }

        public DeleteSchedule()
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

        private void DeleteSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            scheduleDL.deleteScheduleFromList(schedule);
            scheduleDL.storeScheduleInFile();
            Close();
        }
    }
}
