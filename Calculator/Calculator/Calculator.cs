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
            return accum = a + b;
        }
        public double Subtract(double a, double b)
        {
            return accum = a - b;
        }
        public double Multiply(double a, double b)
        {
            return accum = a * b;
        }
        public double Power(double x, double exp)
        {
            if (x < 0)
            {
                throw new CalculatorEx.NegativeBase();
            }
            return accum = Math.Pow(x, exp);
        }
        public double Divide(double dividend, double divisor)
        {
            if (divisor==0)
            {
                throw new CalculatorEx.DivideByZeroException();
            }
            return accum = (dividend / divisor);
        }
        public double Add(double a)
        {
            return accum += a;
        }

        public double Subtract(double a)
        {
            return accum -= a;
        }

        public double Multiply(double a)
        {
            return accum *= a;
        }

        public double Power(double x)
        {
            return accum = Math.Pow(accum, x);
        }

        public double Divide(double divisor)
        {
            return accum /= divisor;
        }
        public string Swap2Chars(char x, char y)
        {
            string satsammen = string.Concat(y, x);
            return satsammen;
        }
        public double accum { get; private set; }

        public void Clear()
        {
            accum = 0;
        }
    }
}
