using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using Xunit;

namespace Kata.SumList
{
    public class Sum
    {
        public IEnumerable<int> Elaborate(List<int> ints)
        {
            return Elaborate(ints);
        }

        public List<int> Elaborate(List<int> ints, int count)
        {
            if(!ints.Any()) return new List<int>();
            var head = ints[0];
            var tail = ints.Skip(1).ToList();

            if (!tail.Any()) return new List<int>{head};
            if (ints[0] == ints[1])
                return Elaborate(tail, count + 1);

            var enumerable = new List<int>{head * count}.Concat(tail).ToList();
            return Elaborate(enumerable, 1);
        }
    }

    public class SumTest
    {
        [Fact]
        public void no_sums()
        {
            var sut = new Sum();

            var actual = sut.Elaborate(new List<int>{1, 2, 3, 4});

            var expected = new List<int>{1, 2, 3, 4};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void duplicates_2()
        {
            var sut = new Sum();

            var actual = sut.Elaborate(new List<int>{1, 2, 2, 3, 4});

            var expected = new List<int>{1, 4, 3, 4};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void more_than_2_duplicates()
        {
            var sut = new Sum();

            var actual = sut.Elaborate(new List<int>{1, 2, 2, 2, 2, 3, 3, 3, 4});

            var expected = new List<int>{1, 8, 9, 4};
            Assert.Equal(expected, actual);
        }
    }
}