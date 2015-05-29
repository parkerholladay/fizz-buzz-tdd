using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzCalculatorTests
    {
        [Test]
        public void CalculatorShouldReturnNumberAsString()
        {
            var calculator = new FizzBuzzCalculator();

            Assert.That(calculator.Calculate(1), Is.EqualTo("1"));
        }
    }
}
