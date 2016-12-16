using System.Collections.Generic;
using System.Linq;

namespace Kata.FizzBuzz
{
    public class FizzBuzz9
    {
        private readonly Dictionary<int, string> _rules;

        public FizzBuzz9()
        {
            _rules = new Dictionary<int, string> { { 15, "FizzBuzz" }, { 5, "Buzz" }, { 3, "Fizz" } };
        }

        public string Play()
        {
            return Join(Play(100));
        }

        private string Join(IEnumerable<string> items)
        {
            return string.Join("\r\n", items);
        }

        private IEnumerable<string> Play(int count)
        {
            return Enumerable.Range(1, count).Select(Next);
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