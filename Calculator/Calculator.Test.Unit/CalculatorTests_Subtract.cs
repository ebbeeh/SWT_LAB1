using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_Subtract
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase(2, 2, 0)]
        [TestCase(2, 4, -2)]
        [TestCase(39, 49, -10)]
        [TestCase(30, 24, 6)]
        public void Test_Subtract(int a, int b, int result)
        {
            Assert.That(result, Is.EqualTo(uut.Subtract(a, b)));
        }

        [TestCase(50, 0)]
        [TestCase(0, 50)]
        [TestCase(-50, 100)]
        public void Test_Subtract(int a, int result)
        {
            uut.Add(50);
            Assert.That(result, Is.EqualTo(uut.Subtract(a)));
        }
    }
}
