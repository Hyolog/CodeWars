using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/592c1dfb912f22055b000099/train/csharp"/>
    [TestClass]
    public class MrSafetyTreasures
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("66542", Unlock("Nokia"));
            Assert.AreEqual("82588", Unlock("Valut"));
            Assert.AreEqual("864538", Unlock("toilet"));
        }

        public static string Unlock(string str)
        {
            str = str.ToLower();
            string code = "";

            Dictionary<char, string> cypher = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            foreach (char c in str)
            {
                foreach (var pair in cypher)
                {
                    if (pair.Value.Contains(c))
                    {
                        code += pair.Key;
                        break;
                    }
                }
            }

            return code;
        }
    }
}
