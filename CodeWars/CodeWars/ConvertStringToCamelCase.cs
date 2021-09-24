using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp"/>
    [TestClass]
    public class ConvertStringToCamelCase
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("theStealthWarrior", ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
            Assert.AreEqual("", ToCamelCase(""));
        }

        public string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            var words = str.Split(new char[] { '_', '-' });

            var result = "";

            result += words[0][0];
            result += words[0].Substring(1, words[0].Length - 1).ToLower();

            for (int i = 1; i < words.Length; i++)
            {
                result += char.ToUpper(words[i][0]);
                result += words[i].Substring(1, words[i].Length - 1).ToLower();
            }

            return result;
        }
    }
}
