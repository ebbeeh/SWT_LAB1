﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal1 = new Calculator();

            double sum1 = cal1.Add(1, 2);
            double sum2 = cal1.Substract(1, 2);
            double sum3 = cal1.Multiply(1, 2);
            double sum4 = cal1.Power(2);
            Console.WriteLine("Sum1: " + sum1 + " sum2: " + sum2 + " sum3: " + sum3 + " sum4: " + sum4);
        }
    }
}
