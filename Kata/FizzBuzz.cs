using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public IEnumerable<char> Play()
        {
            var numbers = Enumerable.Range(1, 100).ToList();
            var withFizzesAndBuzzes = numbers.Select(ChangeIfNeeded);
            return String.Join("\r\n", withFizzesAndBuzzes);
        }

        private string ChangeIfNeeded(int i)
        {
            if (i%5 == 0 && i%3 == 0) return "FizzBuzz";
            if (i%3 == 0) return "Fizz";
            if (i%5 == 0) return "Buzz";
            return i.ToString();
        }
    }
}