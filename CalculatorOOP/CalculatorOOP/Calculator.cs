using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    internal class Calculator
    {
        //Attribute
        private double number1;
        private double number2;
        private double result;

        //Methods
        public void GetNumber1(double num)
        {
            number1 = num;
        }

        public void GetNumber2(double num)
        {
            number2 = num;
        }

        public double Addition()
        {
            result = number1 + number2;
            return result;
        }

        public double Subtraction()
        {
            result = number1 - number2;
            return result;
        }

        public double Multiplication()
        {
            result = number1 * number2;
            return result;
        }

        public double Division()
        {
            result = number1 / number2;
            return result;
        }
    }
}
