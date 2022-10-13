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
    public partial class AddTournament : Form
    {
        public AddTournament()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string tourName = textBox1.Text;
                
                int date = int.Parse(textBox2.Text);
                int month = int.Parse(textBox3.Text);

                if (date <= 0 || date > 31)
                {
                    throw new Exception("Date is Out of Range");
                }
                if (month <= 0 || month > 12)
                {
                    throw new Exception("Month is Out of Range");
                }

                tournament tournament=new tournament(tourName,date,month);
                TournamenDL.addTouramentsTList(tournament);
                tournament.storeTournamentInFile(tournament);
                MessageBox.Show("Tournament Added Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
