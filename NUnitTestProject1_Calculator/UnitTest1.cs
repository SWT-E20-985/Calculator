using NUnit.Framework;
using System;
using Calculator;


namespace NUnitTestProject1_Calculator
{
    [TestFixture]
    public class Tests
    {
        [TestCase(10, 2, 14)]
        [TestCase(35, 6, 47)]
        [TestCase(22, 3, 28)]
        public void UnitTestAdd(double p1, double p2, double result)
        {
            var uut = new Calculator.Calculator();

            uut.Add(p1,p2);
            uut.Add(p2);

            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(10, 2, 6)]
        [TestCase(35, 6, 23)]
        [TestCase(22, 3, 16)]
        public void UnitTestSubtract(double p1, double p2, double result)
        {
            var uut = new Calculator.Calculator();

            uut.Subtract(p1, p2);
            uut.Subtract(p2);

            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }


        [TestCase(10, 2, 40)]
        [TestCase(1, 5, 25)]
        [TestCase(4, 6, 144)]
        public void UnitTestMultiply(double p1, double p2, double result)
        {
            var uut = new Calculator.Calculator();

            uut.Multiply(p1, p2);
            uut.Multiply(p2);

            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(10, 2, 10000)]
        [TestCase(1, 4, 1)]
        [TestCase(2, 2, 16)]
        public void UnitTestPower(double p1, double p2, double result)
        {
            var uut = new Calculator.Calculator();

            uut.Power(p1, p2);
            uut.Power(p2);

            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(1000,5,40)]
        [TestCase(400,4,25)]
        [TestCase(600,5,24)]
        public void UnitTestDivide(double p1,double p2,double result)
        {
            var uut = new Calculator.Calculator();

            uut.Divide(p1, p2);
            uut.Divide(p2);

            Assert.That(uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(1000, 0)]
        [TestCase(5000, 0)]
        [TestCase(700, 0)]
        public void UnitTestDivideException(double p1,double p2)
        {
            var uut = new Calculator.Calculator();

            try
            {

                uut.Divide(p1, p2);
                Assert.Fail();

            }
            catch(Exception){}
        }




    }
}