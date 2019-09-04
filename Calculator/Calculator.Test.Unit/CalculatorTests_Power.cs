using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_Power
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase(2, 2, 4)]
        [TestCase(0, 3, 0)]
        [TestCase(3, 3, 27)]
        public void Test_Power(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(uut.Power(a, b)));
        }
    }
}
