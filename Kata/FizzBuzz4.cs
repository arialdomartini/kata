using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace Kata
{
    public class FizzBuzz4
    {
        private readonly List<Matcher> _matchers;

        public FizzBuzz4()
        {
            _matchers = new List<Matcher>
            {
                new DividesPer(3, "Fizz"),
                new DividesPer(5, "Buzz")
            };
        }

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
            foreach (var matcher in _matchers)
            {
                s += matcher.Contribute(i);
            }

            if (s == "")
                s = i.ToString();
            return s;
        }
    }

    public class DividesPer : Matcher
    {
        private readonly int _i;
        private readonly string _str;

        public DividesPer(int i, string str)
        {
            _i = i;
            _str = str;
        }

        public string Contribute(int i)
        {
            return i%_i == 0 ? _str : "";
        }
    }

    public interface Matcher
    {
        string Contribute(int i);
    }
}
