using System;

namespace ScientificCalculatorApp
{
    public class ScientificCalculator
    {
        // Adds two numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtracts the second number from the first
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplies two numbers
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divides the first number by the second
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }

        // Calculates the power of a number
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        // Calculates the square root of a number
        public double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            return Math.Sqrt(number);
        }

        // Calculates the sine of an angle in radians
        public double Sine(double angle)
        {
            return Math.Sin(angle);
        }

        // Calculates the cosine of an angle in radians
        public double Cosine(double angle)
        {
            return Math.Cos(angle);
        }

        // Calculates the tangent of an angle in radians
        public double Tangent(double angle)
        {
            return Math.Tan(angle);
        }

        // Calculates the natural logarithm of a number
        public double Logarithm(double number)
        {
            if (number <= 0)
                throw new ArgumentException("Logarithm of a non-positive number is not defined.");
            return Math.Log(number);
        }
    }
}
