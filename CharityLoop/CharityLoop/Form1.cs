using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {

            //Variables
            decimal donations;
            decimal totalDonations;
            decimal maxDonations;

            //Input donations
            donations = decimal.Parse(txtDonation.Text);

            maxDonations = 1000;
            totalDonations = 0;

            //While loop - until £1000 is reached
            while (totalDonations < maxDonations)
            {
                totalDonations = totalDonations + donations;
                txtTotalDonated.Text = "£" + totalDonations.ToString();
            }
            MessageBox.Show("All money allocated");
        }

        private void txtDonation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
