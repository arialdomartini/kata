using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using Xunit;

namespace Kata.SumList
{
    public class Sum
    {
        public IEnumerable<int> Elaborate(List<int> ints)
        {
            return (from i in ints group i by i into p select p.Key * p.ToList().Count);
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