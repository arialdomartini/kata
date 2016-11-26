using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            var outs = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                var v = i + 1;
                if (v % 3 == 0 && v % 5 == 0)  outs.Add("FizzBuzz");
                else if (v % 3 == 0)  outs.Add("Fizz");
                else if (v % 5 == 0)  outs.Add("Buzz");
                else outs.Add(v.ToString());
            }
            return outs.Aggregate((i, j) => i + "\r\n" + j);
        }
    }
}
