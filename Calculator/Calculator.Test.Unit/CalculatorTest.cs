﻿using System;
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
        [Test]
        public void Add_AddOneToOne_return2()
        {
            const int EXPECTED_RETURNVALUE = 2;
            //Using AAA pattern

            //Arrange
            var uut = new Calculator();
            //Act
            double returnValue = uut.Add(1, 1);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
    }
}
