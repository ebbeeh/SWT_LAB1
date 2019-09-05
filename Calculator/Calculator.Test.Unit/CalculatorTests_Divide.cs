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
        
        [Test]
        public void Test_DivideByZero()
        {
            Assert.That(()=>uut.Divide(10,0),Throws.TypeOf<CalculatorEx.DivideByZeroException>());
        }


        [TestCase(4, 5)]
        [TestCase(2, 10)]
        [TestCase(20, 1)]
        //TODO: Test divide by zero exception
        public void Test_Divide(double a, double result)
        {
            uut.Add(20);
            Assert.That(result, Is.EqualTo(uut.Divide(a)));
        }
    }
}
