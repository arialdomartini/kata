using System.Linq;
using Xunit;

namespace Kata.CodeWars
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Sum(i => i > 0 ? i : 0);
        }
    }

    public class SumOfPositiveTest
    {
        [Theory]
        [InlineData(new int[]{1, 2, 3, 4, 5}, 15)]
        [InlineData(new int[]{1, -2, 3, 4, 5}, 13)]
        [InlineData(new int[]{-1, 2, 3, 4, -5}, 9)]
        [InlineData(new int[]{}, 0)]
        [InlineData(new int[]{-1, -2, -3, -4, -5}, 0)]
        public void ExampleTest(int[] arr, int result)
        {
            var actual = Kata.CodeWars.SumOfPositive.PositiveSum(arr);

            Assert.Equal(result, actual);
        }
    }
}