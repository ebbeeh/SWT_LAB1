using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x)
        {
            return Math.Exp(x);
        }

        public string Meme(char x, char y)
        {
            string satsammen = string.Concat(y, x);
            return satsammen;
        }
    }
}
