﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Add(double a);

        double Subtract(double a, double b);
        double Subtract(double a);

        double Multiply(double a, double b);
        double Multiply(double a);

        double Power(double x, double exp);
        double Power(double x);

        double Divide(double dividend, double divisor);
        double Divide(double divisor);

        void Clear();

        string Swap2Chars(char x, char y);
        
    }
}
