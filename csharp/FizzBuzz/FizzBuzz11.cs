using System.Collections.Generic;
using System.Linq;

namespace Kata.FizzBuzz
{
    public class FizzBuzz11
    {
        private readonly List<IRule> _rules = new List<IRule>() { new ComposedRule(new List<IRule> { new Rule3(), new Rule5()}), new Rule5(), new Rule3(), new RuleNumber()};

        public string Play()
        {
            return string.Join("\r\n", Enumerable.Range(1, 100).Select(AddItem).ToList());
        }

        private string AddItem(int i)
        {
            return _rules.First(r => r.Evaluate(i)).Value(i);
        }
    }

    internal class ComposedRule : IRule
    {
        private readonly List<IRule> _rules;

        public ComposedRule(List<IRule> rules)
        {
            _rules = rules;
        }

        public bool Evaluate(int i)
        {
            return _rules.TrueForAll(x => x.Evaluate(i));
        }

        public string Value(int i)
        {
            return string.Join("", _rules.Select(rule => rule.Value(i)));
        }
    }
    internal class Rule5 : IRule
    {
        public bool Evaluate(int i)
        {
            return i % 5 == 0;
        }

        public string Value(int i)
        {
            return "Buzz";
        }
    }
    internal class RuleNumber : IRule
    {
        public bool Evaluate(int i)
        {
            return true;
        }

        public string Value(int i)
        {
            return i.ToString();
        }
    }
    internal class Rule3 : IRule
    {
        public bool Evaluate(int i)
        {
            return i % 3 == 0;
        }

        public string Value(int i)
        {
            return "Fizz";
        }
    }

    internal interface IRule
    {
        bool Evaluate(int i);
        string Value(int i);
    }
}