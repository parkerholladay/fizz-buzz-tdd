namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            return
                input % 35 == 0 ? "BuzzBizz" :
                input % 21 == 0 ? "FizzBizz" :
                input % 15 == 0 ? "FizzBuzz" :
                input % 3 == 0 ? "Fizz" :
                input % 5 == 0 ? "Buzz" :
                input % 7 == 0 ? "Bizz" :
                input.ToString();
        }
    }
}
