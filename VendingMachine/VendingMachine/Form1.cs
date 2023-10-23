using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Object
        VendingMachine vendingMachine1;

        private void btnCreateVendingMachine_Click(object sender, EventArgs e)
        {
            vendingMachine1 = new VendingMachine();
        }

        private void btnAddStockChocolate_Click(object sender, EventArgs e)
        {
            //Add stock

            //Input stock amount

            int chocolateStock = int.Parse(txtStockChocolate.Text);
            vendingMachine1.AddChocolateStock(chocolateStock);
        }

        private void btnAddStockCrisps_Click(object sender, EventArgs e)
        {
            //Add stock

            //Input stock amount

            int crispsStock = int.Parse(txtStockCrisps.Text);
            vendingMachine1.AddCrispsStock(crispsStock);
        }

        private void btnAddStockWater_Click(object sender, EventArgs e)
        {
            //Add stock

            //Input stock amount

            int waterStock = int.Parse(txtStockWater.Text);
            vendingMachine1.AddWaterStock(waterStock);
        }

        private void btnBuyChocolate_Click(object sender, EventArgs e)
        {
            //Buy chocolate

            int amount = 1;
            vendingMachine1.BuyChocolate(amount);
        }

        private void btnBuyCrisps_Click(object sender, EventArgs e)
        {
            //Buy crisps

            int amount = 1;
            vendingMachine1.BuyCrisps(amount);
        }

        private void btnBuyWater_Click(object sender, EventArgs e)
        {
            //Buy water

            int amount = 1;
            vendingMachine1.BuyWater(amount);
        }

        private void btnCheckStock_Click(object sender, EventArgs e)
        {
            //Display stock

            int myChocolate = vendingMachine1.GetChocolateAmount();
            int myCrisps = vendingMachine1.GetCrispsAmount();
            int myWater = vendingMachine1.GetWaterAmount();

            MessageBox.Show("The stock is: \nChocolate - " + myChocolate + "\nCrisps - " + myCrisps + "\nWater - " + myWater);
        }
    }
}
