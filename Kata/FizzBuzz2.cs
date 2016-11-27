using System.Linq;

namespace Kata
{
    public class FizzBuzz2
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
            var s = "";
            if (i%3 == 0) s += "Fizz";
            if (i%5 == 0) s += "Buzz";
            if(i%3 != 0 && i%5 !=0) s += i.ToString();
            return s;
        }
    }
}
