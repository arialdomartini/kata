using System.Linq;

namespace Kata
{
    public class FizzBuzz
    {
        public string Play()
        {
            string s = "";

            foreach (var i in Enumerable.Range(1, 100))
            {
                if (DivisibilePer(i, 15)) s += "FizzBuzz";
                else if (DivisibilePer(i, 3)) s += "Fizz";
                else if (DivisibilePer(i, 5)) s += "Buzz";
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