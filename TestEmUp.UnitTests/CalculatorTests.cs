using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void test_valid_input_addition()
    {
        var result = _calculator.Add(5, 3);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void test_valid_input_subtraction()
    {
        var result = _calculator.Subtract(10, 4);
        Assert.AreEqual(6, result);
    }

    [Test]
    public void test_valid_input_multiplication()
    {
        var result = _calculator.Multiply(7, 6);
        Assert.AreEqual(42, result);
    }

    [Test]
    public void test_valid_input_division()
    {
        var result = _calculator.Divide(20, 5);
        Assert.AreEqual(4.0, result);
    }

    [Test]
    public void test_edge_case_addition_with_zero()
    {
        var result = _calculator.Add(0, 10);
        Assert.AreEqual(10, result);
    }

    [Test]
    public void test_edge_case_subtraction_negative_result()
    {
        var result = _calculator.Subtract(3, 5);
        Assert.AreEqual(-2, result);
    }

    [Test]
    public void test_edge_case_multiplication_with_zero()
    {
        var result = _calculator.Multiply(0, 100);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void test_edge_case_division_by_one()
    {
        var result = _calculator.Divide(15, 1);
        Assert.AreEqual(15.0, result);
    }

    [Test]
    public void test_error_case_division_by_zero()
    {
        var ex = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        Assert.That(ex.Message, Is.EqualTo("Division by zero is not allowed."));
    }

    [Test]
    public void test_error_case_invalid_input_types()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => _calculator.Add("five", "three"));
        Assert.That(ex.Message, Is.EqualTo("Input must be an integer."));
    }

    [Test]
    public void test_edge_case_large_numbers_addition()
    {
        var result = _calculator.Add(2147483647, 1);
        Assert.AreEqual(2147483648, result);
    }

    [Test]
    public void test_edge_case_large_numbers_multiplication()
    {
        var result = _calculator.Multiply(100000, 100000);
        Assert.AreEqual(10000000000, result);
    }

    [TearDown]
    public void TearDown()
    {
        // Clean up resources if needed
    }
}