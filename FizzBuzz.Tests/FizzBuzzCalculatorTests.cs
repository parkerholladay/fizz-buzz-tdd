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
        [TestCase(7)]
        [TestCase(8)]
        public void CalculatorShouldReturnNumberAsString(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo(input.ToString()));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void CalculatorShouldReturnFizz(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        public void CalculatorShouldReturnBuzz(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo("Buzz"));
        }
    }
}
