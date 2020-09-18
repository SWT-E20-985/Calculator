using NUnit.Framework;
using System;
using Calculator;


namespace NUnitTestProject1_Calculator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UnitTestAdd()
        {
            var uut = new Calculator.Calculator();

            uut.Add(10,5);
            uut.Add(10);

            Assert.That(uut.Accumulator, Is.EqualTo(25));

        }

        [Test]
        public void UnitTestSubtract()
        {
            var uut = new Calculator.Calculator();

            uut.Subtract(10, 5);
            uut.Subtract(10);

            Assert.That(uut.Accumulator, Is.EqualTo(-5));

        }


        [Test]
        public void UnitTestMultiply()
        {
            var uut = new Calculator.Calculator();

            uut.Multiply(10, 5);
            uut.Multiply(10);

            Assert.That(uut.Accumulator, Is.EqualTo(500));

        }

        [Test]
        public void UnitTestPower()
        {
            var uut = new Calculator.Calculator();

            uut.Power(10, 2);
            uut.Power(2);

            Assert.That(uut.Accumulator, Is.EqualTo(10000));

        }

        [TestCase(1000,5,40)]
        [TestCase(1000,7,13)]
        [TestCase(500,6,35)]
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