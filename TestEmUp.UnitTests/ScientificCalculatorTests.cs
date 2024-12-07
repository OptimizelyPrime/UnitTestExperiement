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
        public void Power_PositiveExponent_ReturnsCorrectResult()
        {
            Assert.AreEqual(8.0, calculator.Power(2, 3), 0.0001);
        }

        [Test]
        public void Power_NegativeExponent_ReturnsCorrectResult()
        {
            Assert.AreEqual(0.125, calculator.Power(2, -3), 0.0001);
        }

        [Test]
        public void SquareRoot_PositiveNumber_ReturnsCorrectResult()
        {
            Assert.AreEqual(2.0, calculator.SquareRoot(4), 0.0001);
        }

        [Test]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-4));
        }

        [Test]
        public void Sine_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(1.0, calculator.Sine(Math.PI / 2), 0.0001);
        }

        [Test]
        public void Cosine_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(-1.0, calculator.Cosine(Math.PI), 0.0001);
        }

        [Test]
        public void Tangent_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(1.0, calculator.Tangent(Math.PI / 4), 0.0001);
        }

        [Test]
        public void Logarithm_ValidInput_ReturnsCorrectResult()
        {
            Assert.AreEqual(1.0, calculator.Logarithm(Math.E), 0.0001);
        }

        [Test]
        public void Logarithm_Zero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(0));
        }
    }
}
