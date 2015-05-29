namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            if (input == 3) return "Fizz";
            if (input == 5) return "Buzz";
            return input.ToString();
        }
    }
}
