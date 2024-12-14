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
        public void test_Add_PositiveNumbers()
        {
            var result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void test_Subtract_PositiveNumbers()
        {
            var result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void test_Multiply_PositiveNumbers()
        {
            var result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void test_Divide_NonZeroDenominator()
        {
            var result = calculator.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void test_Divide_ZeroDenominator_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }

        [Test]
        public void test_Power_PositiveBaseAndExponent()
        {
            var result = calculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void test_SquareRoot_PositiveNumber()
        {
            var result = calculator.SquareRoot(9);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void test_SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.SquareRoot(-1));
        }

        [Test]
        public void test_Sine_AngleInRadians()
        {
            var result = calculator.Sine(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void test_Cosine_AngleInRadians()
        {
            var result = calculator.Cosine(0);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void test_Tangent_AngleInRadians()
        {
            var result = calculator.Tangent(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Logarithm_Zero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(0));
        }
    }
}