using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_Multiply
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase(-2, 2, -4)]
        [TestCase(0, 23, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(12, 18, 216)]
        public void Test_Multiply(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(uut.Multiply(a, b)));
        }
        [TestCase(3, 60)]
        [TestCase(1, 20)]
        [TestCase(0, 0)]
        public void Test_Multiply(double a, double result)
        {
            uut.Add(20);
            Assert.That(result, Is.EqualTo(uut.Multiply(a)));
        }
    }
}
