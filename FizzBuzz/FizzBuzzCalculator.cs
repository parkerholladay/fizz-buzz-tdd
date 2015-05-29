namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            return input%15 == 0 ? "FizzBuzz" :
                input%5 == 0 ? "Buzz" :
                input%3 == 0 ? "Fizz" :
                input.ToString();
        }
    }
}
