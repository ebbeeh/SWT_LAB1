using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    class CalculatorTests_Swap
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [TestCase('x','y', "yx")]
        [TestCase('p', 'X', "Xp")]
        [TestCase('y', 'x', "xy")]
        public void Test_SwapPossitiveNumbers(char a, char b, string result)
        {
            Assert.That(result, Is.EqualTo(uut.Swap2Chars(a, b)));
        }
    }
}
