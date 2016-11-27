using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz3
    {
        public string Play()
        {
            return Play(100);
        }

        public string Play(int count)
        {
            var s = "";
            foreach (var i in Enumerable.Range(1, count))
            {
                s += Append(i);
                if (i < 100)
                    s += "\r\n";
            }
            return s;
        }

        public string Append(int i)
        {
            var couples = new Dictionary<int, string>();
            couples.Add(3, "Fizz");
            couples.Add(5, "Buzz");


            var matches = couples.Where(k => i % k.Key == 0);
            var s = matches.Aggregate("", (current, match) => current + match.Value);

            if (matches.Count() ==  0)
                s = i.ToString();
            return s;
        }
    }
}
