using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    public class Calculator : ICalculator
    {

        public double Accumulator { get; private set; }


        public void Clear()
        {
            Accumulator = 0;
        }

        public Calculator()
        {

        }

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Add(double addend)
        {
            return Accumulator=  addend + Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator =  Accumulator - subtractor;
        }


        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator = multiplier * Accumulator;
        }



        public double Power(double x, double exp)
        {
            return Accumulator = Math.Pow(x, exp);
        }

        public double Power(double exponent)
        {
            return Accumulator = Math.Pow(Accumulator, exponent);
        }


        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new Exception();
            }
            
            return Accumulator = dividend / divisor;

        }

        public double Divide(double divisor)
        {

            if (divisor == 0)
            {
                throw new Exception();
            }
          
                return Accumulator = Accumulator / divisor;
        }
    }
}
