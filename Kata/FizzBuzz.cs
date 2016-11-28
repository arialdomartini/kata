using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        private static Dictionary<int, string> _rules;

        public FizzBuzz()
        {
            _rules = new Dictionary<int, string> { { 15, "FizzBuzz" }, { 3, "Fizz" }, { 5, "Buzz" } };
        }

        public string Play()
        {
            var list = Play(100);
            return string.Join("\r\n", list);
        }

        private static List<string> Play(int count)
        {
            return Enumerable.Range(1, count).Select(TryConvertToFizzBuzz).ToList();
        }

        private static string TryConvertToFizzBuzz(int number)
        {
            return _rules.FirstOrDefault(r => CanBeDivided(number, r.Key)).Value ?? number.ToString();
        }

        private static bool CanBeDivided(int i, int div)
        {
            return i % div == 0;
        }
    }
}