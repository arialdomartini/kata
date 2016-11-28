using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz6
    {
        private readonly Dictionary<int, string> _rules;
        private readonly int _upTo;

        public FizzBuzz6()
        {
            _rules = new Dictionary<int, string>() { { 15, "FizzBuzz" }, { 3, "Fizz" }, { 5, "Buzz" } };
            _upTo = 100;
        }

        public string Play()
        {
            return JoinWith("\r\n", PlayList(_upTo));
        }

        private string JoinWith(string separator, List<string> list)
        {
            return string.Join(separator, list);
        }

        private List<string> PlayList(int upTo)
        {
            return Enumerable.Range(1, upTo).Select(i => Next(i)).ToList();
        }

        private string Next(int i)
        {
            return _rules.FirstOrDefault(r => CanBeDividedBy(i, r.Key)).Value ?? i.ToString();
        }

        private bool CanBeDividedBy(int i, int n)
        {
            return i % n == 0;
        }
    }
}