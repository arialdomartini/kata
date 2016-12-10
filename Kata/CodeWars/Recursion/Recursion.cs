using Xunit;

namespace Kata.CodeWars.Recursion
{
    public class Recursion
    {
        public static ulong Factorial(ulong i)
        {
            return i == 0 ? 1 : i * Factorial(i - 1);
        }

        public class RecursionTest
        {
            [Fact]
            public void should_calculate_recursion()
            {
                Assert.Equal(1.ToString(), Recursion.Factorial(0).ToString());
                Assert.Equal(1.ToString(), Recursion.Factorial(1).ToString());
                Assert.Equal(2.ToString(), Recursion.Factorial(2).ToString());
                Assert.Equal(6.ToString(), Recursion.Factorial(3).ToString());
            }
        }
    }
}