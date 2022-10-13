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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string oldUserName = txtUserName.Text;
            string oldPassword = mtxtPassword.Text;
            string newUserName = textBox1.Text;
            string newPassword = maskedTextBox1.Text;
            bool find = false;
            if (oldUserName == passwordDL.Log.Username && oldPassword == passwordDL.Log.Password)
            {
                for (int i = 0; i <newPassword.Length; i++)
                {
                    if (newPassword[i] == ',')
                    {
                        find = true;
                    }
                }
                for (int i = 0; i <newUserName.Length; i++)
                {
                    if (newUserName[i] == ',')
                    {
                        find = true;
                    }
                }
                if (find)
                {
                    MessageBox.Show("You Cannot Add Comma in Your Username or Password.");
                   
                }
                else
                {
                    passwordDL.Log.Username = newUserName;
                    passwordDL.Log.Password = newPassword;
                    passwordDL.storePassword();
                    MessageBox.Show("Password Changed Successfully.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }
    }
}
