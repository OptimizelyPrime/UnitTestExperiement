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
        public void Logarithm_Zero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Logarithm(0));
        }
    }
}
