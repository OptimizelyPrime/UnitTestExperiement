using NUnit.Framework;

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
        var result = _calculator.Divide(20, 4);
        Assert.AreEqual(5.0, result);
    }

    [Test]
    public void test_edge_case_addition_with_zero()
    {
        var result = _calculator.Add(0, 0);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void test_edge_case_subtraction_negative_value()
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
        var result = _calculator.Divide(10, 0);
        Assert.AreEqual("Division by zero is not allowed.", result);
    }

    [Test]
    public void test_error_case_invalid_input_type()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Add("five", "three"));
    }

    [Test]
    public void test_edge_case_large_integers_addition()
    {
        var result = _calculator.Add(2147483647, 1);
        Assert.AreEqual(2147483648, result);
    }
}