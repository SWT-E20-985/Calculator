using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Calculator
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Power(double x, double exp);
        double Divide(double dividend, double divisor);

        void Clear();
    }
}
