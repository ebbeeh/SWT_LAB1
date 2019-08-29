using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Framework_REAL
{
    public class Calculator
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
        public double Power(double x, double exp)
        {
            return Math.Exp(x);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Calculator cal1 = new Calculator();

            int a = 100;
            int b = 64;
            double result1 = cal1.Add(a, b);
            double result2 = cal1.Substract(a, b);
            double result3 = cal1.Multiply(a, b);
            double result4 = cal1.Power(a, b);
            Console.WriteLine("Add: " + result1 + " Substract: " + result2 + " Multiply: " + result3 + " Power: " + result4);

        }
    }
}
