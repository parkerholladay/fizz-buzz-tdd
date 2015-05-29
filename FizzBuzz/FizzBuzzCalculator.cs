namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            if (input % 3 == 0) return "Fizz";
            if (input % 5 == 0) return "Buzz";
            return input.ToString();
        }
    }
}
