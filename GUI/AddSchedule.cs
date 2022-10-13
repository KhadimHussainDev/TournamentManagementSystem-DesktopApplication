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
    public partial class AddSchedule : Form
    {
        private List<teams> tem=new List<teams>();
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
               
            this.Close();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource=teamsDL.Team;
            comboBox1.DisplayMember = "teamName";
            loadTeam();
            comboBox.DataSource=tem;
            comboBox.DisplayMember = "teamName";
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string team1=comboBox1.Text;
                string team2 = comboBox.Text;
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
                schedule schedule=new schedule(team1,team2,date,month);
                scheduleDL.addintoList(schedule);
                schedule.storeScheduleInFile(schedule);
                MessageBox.Show("Schedule is Added");
                scheduleDL.matchSchedule();
                    Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTeam();
            comboBox.DataSource = null;
            comboBox.DataSource = tem;
            comboBox.DisplayMember = "teamName";
            comboBox.Refresh();
        }
    }
}
