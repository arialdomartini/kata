using System;
using System.Linq;
using System.Text;
using Xunit;

namespace Kata.CodeWars.Diamond
{
    public class Diamond
    {
        public static string print(int n)
        {
            if (n < 1 || n % 2 == 0) return null;

            return string.Join("\n", Enumerable.Range(1, n)
                       .Select(i => BuildRow(n, n - Math.Abs(n + 1 - 2 * i)))) + "\n";
        }

        private static string BuildRow(int n, int i)
        {
            return new String(' ', (n - i) /2) + new String('*', i);
        }
    }

    public class DiamondTest
    {
        public void NullCase()
        {
            var actual = Diamond.print(0);

            Assert.Equal(null, actual);
        }

        [Fact]
        public void NegativeNumbers()
        {
            var actual = Diamond.print(-1);

            Assert.Equal(null, actual);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void EvenCase(int n)
        {
            var actual = Diamond.print(n);

            Assert.Equal(null, actual);
        }

        [Fact]
        public void TestDiamond3()
        {
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.Equal(expected.ToString(), Diamond.print(3));
        }

        [Fact]
        public void TestDiamond5()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.Equal(expected.ToString(), Diamond.print(5));
        }
    }

}