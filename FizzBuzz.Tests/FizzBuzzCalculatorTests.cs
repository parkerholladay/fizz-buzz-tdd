using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzCalculatorTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void CalculatorShouldReturnNumberAsString(int input)
        {
            var calculator = new FizzBuzzCalculator();

            Assert.That(calculator.Calculate(input), Is.EqualTo(input.ToString()));
        }

        [Test]
        public void CalculatorShouldReturnFizz()
        {
            var calculator = new FizzBuzzCalculator();

            Assert.That(calculator.Calculate(3), Is.EqualTo("Fizz"));
        }
    }
}
