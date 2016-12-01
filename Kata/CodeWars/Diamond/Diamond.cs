using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Kata.CodeWars.Diamond
{
    public class Diamond
    {
        public static string print(int n)
        {
            if (n < 0 || n % 2 == 0) return null;
            return string.Join("", GetSequence(n).Select(i => BuildRow(n, i) + "\n"));
        }

        private static string BuildRow(int n, int i)
        {
            return Repeat(' ', (n - i) /2) + Repeat('*', i);
        }

        private static string Repeat(char @char, int times)
        {
            return new String(@char, times);
        }

        public static List<int> GetSequence(int max)
        {
            var half = Enumerable.Range(0, (max + 1) / 2).ToList();

            var reverse = half.AsEnumerable().Reverse().Skip(1);

            return half.Concat(reverse).Select(i => i * 2 + 1).ToList();
        }
    }

    public class DiamondTest
    {
        [Fact]
        public void GetSequenceTest()
        {
            var actual = Diamond.GetSequence(1);

            Assert.Equal(new List<int>{1}, actual);
        }

        [Fact]
        public void GetSequenceTest3()
        {
            var actual = Diamond.GetSequence(3);

            Assert.Equal(new List<int>{1, 3, 1}, actual);
        }

        [Fact]
        public void NullCase()
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
        public void GetSequenceTest5()
        {
            var actual = Diamond.GetSequence(5);

            Assert.Equal(new List<int>{1, 3, 5, 3, 1}, actual);
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