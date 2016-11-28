using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        private Dictionary<int, string> _rules;

        public FizzBuzz()
        {
            _rules = new Dictionary<int, string> { { 15, "FizzBuzz" }, { 5, "Buzz" }, { 3, "Fizz" } };
        }

        public string Play()
        {
            var s = "";
            const int max = 100;
            foreach (var i in Enumerable.Range(1, max))
            {
                s += Next(i);

                if (i != max)
                    s += "\r\n";
            }
            return s;
        }

        private string Next(int i)
        {
            return _rules.FirstOrDefault(r => IsMultipleOf(i, r.Key)).Value ?? i.ToString();
        }

        private static bool IsMultipleOf(int i, int n)
        {
            return i%n == 0;
        }
    }
}