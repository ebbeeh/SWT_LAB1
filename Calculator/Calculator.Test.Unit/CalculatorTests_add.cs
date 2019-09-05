using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_add
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase(2, 2, 4)]
        [TestCase(4, 4, 8)]
        [TestCase(1, 1, 2)]
        [TestCase(10, 10, 20)]
        public void Test_AddPossitiveNumbers(int a, int b, int result)
        {
            Assert.That(result, Is.EqualTo(uut.Add(a, b)));
        }

    }
}
