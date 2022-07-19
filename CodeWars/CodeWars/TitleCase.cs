using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp"/>
    [TestClass]
    public class TitleCase
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("", TitleCaseFunc(""));
            Assert.AreEqual("The Quick Brown Fox", TitleCaseFunc("the quick brown fox"));
            Assert.AreEqual("The Wind in the Willows", TitleCaseFunc("THE WIND IN THE WILLOWS", "The In"));
            Assert.AreEqual("A Clash of Kings", TitleCaseFunc("a clash of KINGS", "a an the of"));
            Assert.AreEqual("Abc Def Ghi", TitleCaseFunc("aBC deF Ghi", null));
        }

        public static string TitleCaseFunc(string title, string minorWords = "")
        {
            if (string.IsNullOrWhiteSpace(title))
                return title;

            var words = title.ToLower().Split(' ');
            var minor = minorWords == null ? "".Split(' ') : minorWords.ToLower().Split(' ');
            var result = new List<string>();

            result.Add(ChangeToPascalCase(words[0]));

            for (int i = 1; i < words.Length; i++)
            {
                if (minor.Contains(words[i]))
                {
                    result.Add(words[i]);
                }
                else
                {
                    result.Add(ChangeToPascalCase(words[i]));
                }
            }

            return string.Join(" ", result);
        }

        private static string ChangeToPascalCase(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
    }
}
