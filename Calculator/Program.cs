using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();
            //ændret (test)
            //ændring 2 (test)
            //ændring 3 for jenkins (test)
            calc.Add(10, 5);
            calc.Add(10);
            Console.WriteLine("plus: {0}", calc.Accumulator);
            calc.Clear();
            calc.Subtract(10, 5);
            calc.Subtract(10);
            Console.WriteLine("minus: {0}", calc.Accumulator);
            calc.Clear();
            calc.Multiply(10, 2);
            calc.Multiply(2);
            Console.WriteLine("gange: {0}", calc.Accumulator);
            calc.Clear();
            calc.Power(10, 2);
            calc.Power(2);
            Console.WriteLine("exponent: {0}", calc.Accumulator);
            calc.Clear();
            calc.Divide(10, 2);
            calc.Divide(2);
            Console.WriteLine("division: {0}", calc.Accumulator);
            calc.Clear();

            calc.Clear();
            Console.WriteLine("clear funktion: {0}", calc.Accumulator);

            //exceptions

            calc.Divide(10, 0);
            Console.WriteLine("division(exception): {0}", calc.Accumulator);
            




        }
    }
}
