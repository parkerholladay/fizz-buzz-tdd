using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new FizzBuzzCalculator();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(calculator.Calculate(i));
            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
