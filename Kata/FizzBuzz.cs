using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            var s = "";
            foreach (var i in Enumerable.Range(1, 100))
            {
                if(i % 15 == 0) s += "FizzBuzz";
                else if(i % 3 == 0) s += "Fizz";
                else if (i%5 == 0) s += "Buzz";
                else s += i.ToString();

                if (i != 100)
                    s += "\r\n";
            }
            return s;
        }
    }
}