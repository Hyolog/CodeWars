using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54b724efac3d5402db00065e"/>
    [TestClass]
    public class DecodeTheMorseCode
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("HEY JUDE", ".... . -.--   .--- ..- -.. .");
        }

        public string Decode(string morseCode)
        {
            var result = new StringBuilder();

            var words = morseCode.Split("   ");
            
            foreach (var word in words)
            {
                var characters = word.Split(' ');

                foreach (var character in characters)
                {
                    var convertedCharacter = MorseCode.Get(character);
                    result.Append(convertedCharacter);
                }

                result.Append(" ");
            }

            return result.ToString().Trim();
        }

        public class MorseCode
        {
            public static string Get(string character)
            {
                return character;
            }
        }
    }
}
