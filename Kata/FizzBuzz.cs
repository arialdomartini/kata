using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            var ss = new List<string>();

            foreach (var i in Enumerable.Range(1, 100))
            {
                ss.Add(Next(i));
            }
            return string.Join("\r\n", ss);
        }

        private string Next(int i)
        {
            var rules = new Dictionary<int, string>(){ { 3, "Fizz"}, {5, "Buzz"}};
            var matching = rules.Where(w => IsMultipleOf(i, w.Key));
            if (!matching.Any())
                return i.ToString();
            return string.Join("", matching.Select(k => k.Value));
        }

        private static bool IsMultipleOf(int i, int n)
        {
            return i % n == 0;
        }

        private static string Append(string s, string fizz)
        {
            return s + fizz;
        }
    }
}