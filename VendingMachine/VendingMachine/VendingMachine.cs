using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VendingMachine
{
    internal class VendingMachine
    {

        //Attributes
        private int chocolate;
        private int crisps;
        private int water;

        //Methods
        public void BuyChocolate(int amount)
        {
            chocolate = chocolate - amount;
        }

        public void BuyCrisps(int amount)
        {
            crisps = crisps - amount;
        }

        public void BuyWater(int amount)
        {
            water = water - amount;
        }

        public void AddChocolateStock(int stock)
        {
            chocolate = chocolate + stock;
        }

        public void AddCrispsStock(int stock)
        {
            crisps = crisps + stock;
        }

        public void AddWaterStock(int stock)
        {
            water = water + stock;
        }

        public int GetChocolateAmount()
        {
            return chocolate;
        }

        public int GetCrispsAmount()
        {
            return crisps;
        }

        public int GetWaterAmount()
        {
            return water;
        }
    }
}
