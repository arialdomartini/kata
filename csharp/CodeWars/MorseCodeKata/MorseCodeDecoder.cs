using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Kata.CodeWars.MorseCodeKata
{
    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            return string.Join(" ",
                morseCode.Split(new[] {"  "}, StringSplitOptions.None)
                    .Select(word => string.Join("",
                        word.Split(' ').Select(MorseCode.Get)
                    )));
        }
    }

    internal class MorseCode
    {
        public static string Get(string value)
        {
            return "";
        }
    }


    public class MorseCodeDecoderTests
    {
        [Fact]
        public void MorseCodeDecoderBasicTest_1()
        {
            var input = ".... . -.--   .--- ..- -.. .";
            var expected = "HEY JUDE";

            var actual = MorseCodeDecoder.Decode(input);

            Assert.Equal(expected, actual);
        }
    }
}