using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace ConsoleApp2.tests
{
    [TestClass]
    public class RationalNumberUnitTests
    {
        [TestMethod]
        public void Constructor_ValidInput_CreatesNormalizedRationalNumber()
        {
            // Arrange
            int numerator = 10;
            int denominator = 20;

            // Act
            RationalNumber number = new RationalNumber(numerator, denominator);

            // Assert
            Assert.AreEqual(1, number.Numerator);
            Assert.AreEqual(2, number.Denominator);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ZeroDenominator_ThrowsArgumentException()
        {
            // Arrange
            int numerator = 10;
            int denominator = 0;

            // Act & Assert
            RationalNumber number = new RationalNumber(numerator, denominator);
        }

        [TestMethod]
        public void ToString_ValidRationalNumber_ReturnsStringRepresentation()
        {
            // Arrange
            RationalNumber number = new RationalNumber(1, 2);

            // Act
            string result = number.ToString();

            // Assert
            Assert.AreEqual("1/2", result);
        }

        [TestMethod]
        public void Simplify_NegativeNumeratorAndDenominator_NormalizesToPositive()
        {
            // Arrange
            RationalNumber number = new RationalNumber(-1, -2);

            // Act & Assert
            Assert.AreEqual(1, number.Numerator);
            Assert.AreEqual(2, number.Denominator);
        }

        [TestMethod]
        public void OperatorAdd_ValidRationalNumbers_AddsCorrectly()
        {
            // Arrange
            RationalNumber number1 = new RationalNumber(1, 2);
            RationalNumber number2 = new RationalNumber(1, 3);

            // Act
            RationalNumber result = number1 + number2;

            // Assert
            Assert.AreEqual(5, result.Numerator);
            Assert.AreEqual(6, result.Denominator);
        }

        [TestMethod]
        public void OperatorSubtract_ValidRationalNumbers_SubtractsCorrectly()
        {
            // Arrange
            RationalNumber number1 = new RationalNumber(1, 2);
            RationalNumber number2 = new RationalNumber(1, 3);

            // Act
            RationalNumber result = number1 - number2;

            // Assert
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(6, result.Denominator);
        }

        [TestMethod]
        public void OperatorEquals_EqualRationalNumbers_ReturnsTrue()
        {
            // Arrange
            RationalNumber number1 = new RationalNumber(1, 2);
            RationalNumber number2 = new RationalNumber(2, 4);

            // Act & Assert
            Assert.IsTrue(number1 == number2);
        }

        [TestMethod]
        public void OperatorNotEquals_NotEqualRationalNumbers_ReturnsTrue()
        {
            // Arrange
            RationalNumber number1 = new RationalNumber(1, 2);
            RationalNumber number2 = new RationalNumber(1, 3);

            // Act & Assert
            Assert.IsTrue(number1 != number2);
        }

        // Дополнительные тесты для операторов <, >, <=, >= можно добавить аналогичным образом.
    }
}