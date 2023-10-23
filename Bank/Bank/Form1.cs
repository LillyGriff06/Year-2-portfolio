using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Account object

        Account account1;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create an account

            account1 = new Account();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Make a deposit

            //Input the deposit amount

            decimal depositAmount = decimal.Parse(txtDeposit.Text);

            account1.MakeDeposit(depositAmount);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Display balance

            decimal myBalance = account1.GetBalance();

            MessageBox.Show("Your balance is £" + myBalance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Make withdrawal

            //Input the withdrawal amount

            decimal withdrawAmount = decimal.Parse(txtWithdraw.Text);

            account1.MakeWithdrawal(withdrawAmount);
        }
    }
}
