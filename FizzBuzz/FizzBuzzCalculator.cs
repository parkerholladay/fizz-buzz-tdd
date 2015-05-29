namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            var output = "";

            if (input % 3 == 0) output += "Fizz";
            if (input % 5 == 0) output += "Buzz";

            return string.IsNullOrWhiteSpace(output) ? input.ToString() : output;
        }
    }
}
