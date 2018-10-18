using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        static readonly Dictionary<int, string> divisors = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" },
            { 7, "Bizz" },
            { 11, "Bazz" }
        };

        public string Calculate(int input)
        {
            var specialCase = GetSpecialCases(input);
            if (string.IsNullOrWhiteSpace(specialCase))
            {
                return input.ToString();
            }

            return specialCase;
        }

        string GetSpecialCases(int input)
        {
            var result = "";

            foreach (int key in divisors.Keys)
            {
                if (input % key == 0)
                {
                    result += divisors[key];
                }
            }

            return result;
        }
    }
}
