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
            var sequence = GetSequence(n);
            return string.Join("\n", sequence.Select(i => BuildRow(n, i))) + "\n";
        }

        private static string BuildRow(int n, int i)
        {
            if (n - i == 0) return new String('*', i);
            return new String(' ', (n - i) /2) + new String('*', i);
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