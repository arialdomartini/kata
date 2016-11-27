using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            var results = new List<string>();

            var rules = new Dictionary<int, string>() { {15, "FizzBuzz"}, {3, "Fizz"}, {5, "Buzz"} };

            foreach (var i in Enumerable.Range(1, 100))
            {
                var firstOrDefault = rules.FirstOrDefault(r => DivisibilePer(i, r.Key));
                results.Add(firstOrDefault.Value ?? i.ToString());
            }
            return string.Join("\r\n", results);
        }

        private bool DivisibilePer(int i, int n)
        {
            return i % n == 0;
        }
    }
}