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
    public partial class EditPoints : Form
    {
        private static teams team;
        public EditPoints()
        {
            InitializeComponent();
        }

        internal static teams Team { get => team; set => team = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditPoints_Load(object sender, EventArgs e)
        {
            textBox1.Text = team.TeamName;
            textBox2.Text=team.TotalPlayedMatches.ToString();
            textBox3.Text=team.WonMatches.ToString();
            textBox4.Text=(int.Parse(textBox2.Text)-int.Parse(textBox3.Text)).ToString();
            textBox5.Text = (2 * int.Parse(textBox3.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!=""&& textBox3.Text != "")
            {

            textBox4.Text = (int.Parse(textBox2.Text) - int.Parse(textBox3.Text)).ToString();
            textBox5.Text = (2 * int.Parse(textBox3.Text)).ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "")
            {
                textBox4.Text = (int.Parse(textBox2.Text) - int.Parse(textBox3.Text)).ToString();
            textBox5.Text = (2 * int.Parse(textBox3.Text)).ToString();
        }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                int total = int.Parse(textBox2.Text);
                int won = int.Parse(textBox3.Text);
                int lost=int.Parse(textBox4.Text);
                int point=int.Parse(textBox5.Text);
                if (won > total)
                {
                    throw new Exception("Won Matches cannot Exceed Total Played Matches");
                }
                team.TotalPlayedMatches = total;
                team.WonMatches = won;
                team.LostMatches = lost;
                team.Points = point;



                teamsDL.storeTeamsInFile();
                MessageBox.Show("Point Table Updated Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
