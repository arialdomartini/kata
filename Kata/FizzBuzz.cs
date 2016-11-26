using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace Kata
{
    public class FizzBuzz
    {
        public IEnumerable<char> Play()
        {
            var numbers = Enumerable.Range(1, 100);
            return Play(numbers);
        }

        private IEnumerable<char> Play(IEnumerable<int> numbers)
        {
            var withFizzesAndBuzzes = numbers.Select(ChangeIfNeeded);
            return Join("\r\n", withFizzesAndBuzzes);
        }

        private string ChangeIfNeeded(int i)
        {
            var maps = new Dictionary<int, string>() { {3, "Fizz"}, {5, "Buzz"} };
            if (maps.All(k => i%k.Key != 0)) return i.ToString();
            return Join("", maps.Where(k => i % k.Key== 0).Select(k => k.Value));
        }
    }
}