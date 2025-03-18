using NUnit.Framework;

namespace MyApp.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = _calculator.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfArguments()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfNegativeArguments()
        {
            var result = _calculator.Multiply(-2, -3);
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
