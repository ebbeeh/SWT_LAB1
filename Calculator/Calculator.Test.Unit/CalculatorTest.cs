using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        [Test]
        public void Add_AddOneToOne_return2()
        {
            const int EXPECTED_RETURNVALUE = 2;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Add(1, 1);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Subtract_Sub2From5_return3()
        {
            const int EXPECTED_RETURNVALUE = 3;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Subtract(5, 2);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Multiply_Multi2and2_return4()
        {
            const int EXPECTED_RETURNVALUE = 4;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Multiply(2, 2);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Power_2tothePowerof4_return16()
        {
            const int EXPECTED_RETURNVALUE = 16;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Power(2,4);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Power_3tothePowerof2_return9()
        {
            const int EXPECTED_RETURNVALUE = 9;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Power(3, 2);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Power_9tothePowerof13_return2541865828329()
        {
            const double EXPECTED_RETURNVALUE = 2541865828329;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Power(9, 13);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Divide_4dividedby4_return1()
        {
            const double EXPECTED_RETURNVALUE = 1;
            //Using AAA pattern

            //Arrange
            //Act
            double returnValue = uut.Divide(4, 4);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Divide_12dividedby2_return6()
        {
            const double EXPECTED_RETURNVALUE = 6;
            //Using AAA pattern

            //Arrange
            //Act
            double returnValue = uut.Divide(12, 2);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Swap_xySwapped_returnyx()
        {
            const string EXPECTED_RETURNVALUE = "yx";
            //Using AAA pattern

            //Arrange
            //Act
            string returnValue = uut.Swap2Chars('x', 'y');
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Swap_yxSwapped_returnxy()
        {
            const string EXPECTED_RETURNVALUE = "xy";
            //Using AAA pattern

            //Arrange
            //Act
            string returnValue = uut.Swap2Chars('y', 'x');
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
        [Test]
        public void Swap_PxSwapped_returnxP()
        {
            const string EXPECTED_RETURNVALUE = "xP";
            //Using AAA pattern

            //Arrange
            //Act
            string returnValue = uut.Swap2Chars('P', 'x');
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
    }
}
