using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace Kata
{
    public class FizzBuzz
    {
        private readonly List<Matcher> _matchers;

        public FizzBuzz()
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
                if (matcher.Matches(i))
                    s += matcher.Contribute();
            }

            if (_matchers.Count(m=> m.Matches(i)) ==  0)
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

        public bool Matches(int i)
        {
            return i%_i == 0;
        }

        public string Contribute()
        {
            return _str;
        }
    }

    public interface Matcher
    {
        bool Matches(int i);
        string Contribute();
    }
}
