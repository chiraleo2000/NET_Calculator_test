using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(5, 3, 8)]
        [TestCase(-1, -1, -2)]
        public void Add_WhenCalled_ReturnsSum(double a, double b, double expected)
        {
            double result = calculator.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        public void Subtract_WhenCalled_ReturnsSum(double a, double b, double expected)
        {
            double result = calculator.Subtract(a, b);
            Assert.AreEqual(expected, result);
        }

        public void Multiply_WhenCalled_ReturnsSum(double a, double b, double expected)
        {
            double result = calculator.Multiply(a, b);
            Assert.AreEqual(expected, result);
        }

        public void Divide_WhenCalled_ReturnsSum(double a, double b, double expected)
        {
            double result = calculator.Divide(a, b);
            Assert.AreEqual(expected, result);
        }
        // Additional tests for Subtract, Multiply, Divide...
    }
}
