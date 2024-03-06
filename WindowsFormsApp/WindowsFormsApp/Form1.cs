using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                //Input data for num1 and num2 - allow decimals
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                //Divide numbers
                int answer = num1 / num2;
                //Display answer
                MessageBox.Show("Division: \n" + answer.ToString());
            }
            catch(Exception ex) 
            {
                MessageBox.Show("There was an Exception: " + ex.Message);
            }
        }
    }
}
