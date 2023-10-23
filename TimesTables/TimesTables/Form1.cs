using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimesTables_Click(object sender, EventArgs e)
        {

            //Variables
            int timesTables;
            int number;
            int answer;

            number = 0;

            //Input timesTables
            timesTables = int.Parse(txtNumber.Text);

            //Loop 12 times
            for (int i = 0; i < 12; i += 1)
            {
                number += 1;
                answer = number * timesTables;
                txtTimesTables.Text += number.ToString() + "X" + timesTables.ToString() + "=" + answer.ToString() + "\r\n";
            }
        }
    }
}
