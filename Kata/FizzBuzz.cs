using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            string s = "";

            var rules = new Dictionary<int, string>() { {15, "FizzBuzz"}, {3, "Fizz"}, {5, "Buzz"} };

            foreach (var i in Enumerable.Range(1, 100))
            {
                var firstOrDefault = rules.FirstOrDefault(r => DivisibilePer(i, r.Key));
                if (firstOrDefault.Value != null) s += firstOrDefault.Value;
                else s += i;

                if (i!= 100)
                    s = Separate(s);
            }
            return s;
        }

        private static string Separate(string str)
        {
            return str + "\r\n";
        }

        private bool DivisibilePer(int i, int n)
        {
            return i % n == 0;
        }
    }
}