using BL;
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
    public partial class EditTeam : Form
    {
        private static teams team;

        public EditTeam( )
        {
            InitializeComponent();
        }

        internal static teams Team { get => team; set => team = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string teamName = textBox1.Text;
                string ownerName = textBox2.Text;
                string captainName = textBox3.Text;
                int captainAge = int.Parse(textBox4.Text);
                string viceCaptainName = textBox5.Text;
                int viceCaptainAge = int.Parse(textBox6.Text);
                if (teamName == "" || ownerName == "" || captainName == "" || viceCaptainName == "")
                {
                    throw new Exception("Please Fill All Fields.Thanks");
                }
                if (captainAge <= 15 || captainAge >= 50)
                {
                    throw new Exception("Captain's Age is Out of Range");
                }
                if (viceCaptainAge <= 15 || viceCaptainAge >= 50)
                {
                    throw new Exception("Vice Captain's Age is Out of Range");
                }
                Team.TeamName=teamName; 
                Team.OwnerName=ownerName;   
                Team.CaptainName=captainName;
                Team.CaptainAge=captainAge;
                Team.ViceCaptainName=viceCaptainName;
                Team.ViceCaptainAge=viceCaptainAge;
                teamsDL.storeTeamsInFile();
                MessageBox.Show("Team Updated Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditTeam_Load(object sender, EventArgs e)
        {
            textBox1.Text = Team.TeamName;
            textBox2.Text = Team.OwnerName;
            textBox3.Text = Team.CaptainName;
            textBox4.Text = Team.CaptainAge.ToString();
            textBox5.Text = Team.ViceCaptainName;
            textBox6.Text = Team.ViceCaptainAge.ToString();
        }
    }
}
