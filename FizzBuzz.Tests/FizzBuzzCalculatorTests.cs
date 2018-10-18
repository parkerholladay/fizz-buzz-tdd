using System.Collections;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1).Returns("1");
                yield return new TestCaseData(2).Returns("2");
                yield return new TestCaseData(3).Returns("Fizz");
                yield return new TestCaseData(4).Returns("4");
                yield return new TestCaseData(5).Returns("Buzz");
                yield return new TestCaseData(6).Returns("Fizz");
                yield return new TestCaseData(7).Returns("Bizz");
                yield return new TestCaseData(8).Returns("8");
                yield return new TestCaseData(9).Returns("Fizz");
                yield return new TestCaseData(10).Returns("Buzz");
                yield return new TestCaseData(11).Returns("11");
                yield return new TestCaseData(12).Returns("Fizz");
                yield return new TestCaseData(13).Returns("13");
                yield return new TestCaseData(14).Returns("Bizz");
                yield return new TestCaseData(15).Returns("FizzBuzz");
                yield return new TestCaseData(16).Returns("16");
                yield return new TestCaseData(17).Returns("17");
                yield return new TestCaseData(18).Returns("Fizz");
                yield return new TestCaseData(19).Returns("19");
                yield return new TestCaseData(20).Returns("Buzz");
                yield return new TestCaseData(21).Returns("FizzBizz");
                yield return new TestCaseData(25).Returns("Buzz");
                yield return new TestCaseData(30).Returns("FizzBuzz");
                yield return new TestCaseData(35).Returns("BuzzBizz");
                yield return new TestCaseData(45).Returns("FizzBuzz");
            }
        }
    }

    [TestFixture]
    public class FizzBuzzCalculatorTests
    {
        private FizzBuzzCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new FizzBuzzCalculator();
        }

        [Test, TestCaseSource(typeof(FizzBuzzTestData), "TestCases")]
        public string CalculateTests(int input)
        {
            return _calculator.Calculate(input);
        }
    }
}
