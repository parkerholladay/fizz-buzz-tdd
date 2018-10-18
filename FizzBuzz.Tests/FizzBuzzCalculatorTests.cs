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
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        public void CalculatorShouldReturnNumberAsString(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo(input.ToString()));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        public void CalculatorShouldReturnFizz(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void CalculatorShouldReturnBuzz(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void CalculatorShouldReturnFizzBuzz(int input)
        {
            Assert.That(_calculator.Calculate(input), Is.EqualTo("FizzBuzz"));
        }
    }
}
