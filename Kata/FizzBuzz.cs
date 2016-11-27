using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public IEnumerable<char> Play()
        {
            var numbers = Enumerable.Range(1, 100).ToList().Select(i => i.ToString());
            var withFizzesAndBuzzes = numbers.Select(ChangeIfNeeded);
            return String.Join("\r\n", withFizzesAndBuzzes);
        }

        private string ChangeIfNeeded(string s)
        {
            var s1 = Int32.Parse(s);
            if (s1%5 == 0 && s1%3 == 0) return "FizzBuzz";
            if (s1%3 == 0) return "Fizz";
            if (s1%5 == 0) return "Buzz";
            return s;
        }
    }
}