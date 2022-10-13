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
    public partial class EditScheduledMatch : Form
    {
        private static schedule schedule;
        private List<teams> tem = new List<teams>();
        public EditScheduledMatch()
        {
            InitializeComponent();
        }

        internal static schedule Schedule { get => schedule; set => schedule = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditScheduledMatch_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = teamsDL.Team;
            comboBox1.DisplayMember = "teamName";
            loadTeam();
            comboBox2.DataSource = tem;
            comboBox2.DisplayMember = "teamName";
            comboBox1.Text = schedule.Team1Name;
            comboBox2.Text = schedule.Team2Name;
            textBox1.Text = schedule.Date.ToString();
            textBox2.Text = schedule.Month.ToString();
        }
        private void loadTeam()
        {
            tem.Clear();
            foreach (teams t in teamsDL.Team)
            {
                if (comboBox1.SelectedItem == t)
                {

                }
                else
                {

                    tem.Add(t);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeam();
            comboBox2.DataSource = null;
            comboBox2.DataSource = tem;
            comboBox2.DisplayMember = "teamName";
            comboBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string team1 = comboBox1.Text;
                string team2 = comboBox2.Text;
                int date = int.Parse(textBox1.Text);
                int month = int.Parse(textBox2.Text);
                if (date <= 0 || date > 31)
                {
                    throw new Exception("Date is out of Range.");
                }
                if (month <= 0 || month > 12)
                {
                    throw new Exception("Month is Out of Range.");
                }
                schedule.Team1Name = comboBox1.Text;
                schedule.Team2Name = comboBox2.Text;
                schedule.Date = date;
                schedule.Month = month;
                schedule.Year = 2022;
                schedule.Time = date + (month * 30);
                scheduleDL.storeScheduleInFile();
                MessageBox.Show("Schedule is updated");
                scheduleDL.matchSchedule();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
