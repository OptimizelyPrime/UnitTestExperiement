using NUnit.Framework;
using System;

namespace TestemUp.Tests
{
    [TestFixture]
    public class ScientificCalculatorTests
    {
        private ScientificCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new ScientificCalculator();
        }

        [Test]
        public void Add_ValidInput_ReturnsCorrectSum()
        {
            double result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_ValidInput_ReturnsCorrectDifference()
        {
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ValidInput_ReturnsCorrectProduct()
        {
            double result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_ValidInput_ReturnsCorrectQuotient()
        {
            double result = calculator.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Divide_ZeroDenominator_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }

        [Test]
        public void Power_ValidInput_ReturnsCorrectResult()
        {
            double result = calculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void SquareRoot_PositiveNumber_ReturnsCorrectRoot()
        {
            double result = calculator.SquareRoot(4);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }

        [Test]
        public void Sine_ValidInput_ReturnsCorrectValue()
        {
            double result = calculator.Sine(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Cosine_ValidInput_ReturnsCorrectValue()
        {
            double result = calculator.Cosine(0);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Tangent_ValidInput_ReturnsCorrectValue()
        {
            double result = calculator.Tangent(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Logarithm_Zero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(0));
        }

        [Test]
        public void Logarithm_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(-1));
        }
    }
}