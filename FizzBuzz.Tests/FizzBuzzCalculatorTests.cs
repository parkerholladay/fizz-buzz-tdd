using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzCalculatorTests
    {
        private FizzBuzzCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new FizzBuzzCalculator();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void CalculatorShouldReturnNumberAsString(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo(input.ToString()));
        }

        [Test]
        public void CalculatorShouldReturnFizz()
        {
            Assert.That(_calculator.Calculate(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void CalculatorShouldReturnBuzz()
        {
            Assert.That(_calculator.Calculate(5), Is.EqualTo("Buzz"));
        }
    }
}
