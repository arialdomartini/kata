using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        private Dictionary<int, string> _rules;

        public FizzBuzz()
        {
            _rules = new Dictionary<int, string>
            {
                { 15, "FizzBuzz" },
                { 3, "Fizz" },
                { 5, "Buzz" }
            };
        }

        public string Play()
        {
            return string.Join("\r\n", Play(100));
        }

        private IEnumerable<string> Play(int count)
        {
            return Enumerable.Range(1, count).Select(ConvertToFizzBuzz);
        }

        private string ConvertToFizzBuzz(int i)
        {
            var str = _rules.FirstOrDefault(r => i.IsMultipleOf(r.Key));
            return str.Value ?? i.ToString();
        }
    }

    public static class IntExt
    {
        public static bool IsMultipleOf(this int i, int div)
        {
            return i % div == 0;
        }
    }
}