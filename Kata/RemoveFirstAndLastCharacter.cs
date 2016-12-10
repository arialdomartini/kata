using System.Linq;
using Xunit;

namespace Kata
{
    public class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            return new string(s.ToArray().Take(s.Length -1).Skip(1).ToArray());
        }
    }

    public class RemoveFirstAndLastCharacterTest
    {
        [Theory]
        [InlineData("eloquent", "loquen")]
        [InlineData("country", "ountr")]
        [InlineData("person", "erso")]
        [InlineData("place", "lac")]
        [InlineData("ok", "")]
        public void Test1(string given, string expected)
        {
            Assert.Equal(expected, RemoveFirstAndLastCharacter.Remove_char(given));
        }
    }
}
