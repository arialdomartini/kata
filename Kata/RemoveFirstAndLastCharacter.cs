using System.Text.RegularExpressions;
using Xunit;

namespace Kata
{
    public class RemoveFirstAndLastCharacter
    {
        public static string Remove_char(string s)
        {
            return Regex.Replace(s, "^.|.$", "");
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
        public void should_remove_first_and_last_characted_in_a_string(string given, string expected)
        {
            Assert.Equal(expected, RemoveFirstAndLastCharacter.Remove_char(given));
        }
    }
}
