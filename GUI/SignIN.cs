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
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void SignIN_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username=txtUserName.Text;
            string password=mtxtPassword.Text;
            logInfo logInfo=new logInfo(username,password);

            if (logInfo.athentication())
            {
                hideForms();
                AdminMenu adminMenu=new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                this.Hide();
            }
        }
        private void hideForms()
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }
        }
        
    }
}
