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
            var s = "";
            if (i % 3 == 0) s = "Fizz";
            if (i % 5 == 0) s += "Buzz";
            if (i % 3 != 0 && i % 5 != 0) s += i.ToString();
            return s;
        }
    }
}