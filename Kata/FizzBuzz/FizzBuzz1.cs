using System.Collections.Generic;
using System.Linq;

namespace Kata.FizzBuzz
{
    public class FizzBuzz1
    {
        public string Play()
        {
            var outs = new List<string>();
            foreach (var i in Enumerable.Range(1, 100))
            {
                if (i % 3 == 0 && i % 5 == 0)  outs.Add("FizzBuzz");
                else if (i % 3 == 0)  outs.Add("Fizz");
                else if (i % 5 == 0)  outs.Add("Buzz");
                else outs.Add(i.ToString());
            }
            return outs.Aggregate((i, j) => i + "\r\n" + j);
        }
    }
}
