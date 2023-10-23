using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPopup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            //Variables
            string username;
            string password;
            string correctUsername;
            string correctPassword;

            //Correct username
            correctUsername = "Admin123";

            //Correct password
            correctPassword = "Password123";

            //Input username
            username = txtUsername.Text;

            //Input password
            password = txtPassword.Text;

            //Check inputs

            if (username ==correctUsername)
            {
                if (password == correctPassword)
                {
                    MessageBox.Show("Successfully logged in");
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            else {
                MessageBox.Show("Incorrect username or password");
            }

        }
    }
}
