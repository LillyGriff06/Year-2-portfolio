using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal class Account
    {

        //Attributes
        private string customerName;
        private string accountNumber;
        private decimal balance;

        //Methods
        public void MakeDeposit(decimal amount)
        {
            balance = balance + amount; 
        }

        public void MakeWithdrawal(decimal amount)
        {
            if (balance > amount){
                balance = balance - amount;
            }
            else
            {
                MessageBox.Show("Money cannot be withdrawn. Overdrawn.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
