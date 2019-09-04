using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_Divide
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase(2, 2, 1)]
        [TestCase(30, 3, 10)]
        [TestCase(20, 5, 4)]
        [TestCase(9, 3, 3)]
        public void Test_Divide(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(uut.Divide(a, b)));
        }
    }
}
