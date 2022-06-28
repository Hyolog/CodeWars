using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/559536379512a64472000053/train/csharp"/>
    [TestClass]
    public class PlayingWithPassphrases
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("!!!vPz fWpM J", playPass("I LOVE YOU!!!", 1));
            Assert.AreEqual("78", playPass("12", 1));
            Assert.AreEqual("CoPcTi aO", playPass("MY GRANMA", 2));
            Assert.AreEqual("OqTh gOcE", playPass("CAME FROM", 2));
            Assert.AreEqual("4897 NkTrC", playPass("APRIL 2015", 2));
        }

        public static string playPass(string s, int n)
        {
            var result = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var item = s[i];

                if (char.IsLetter(item))
                {
                    var num = (int)item;
                    num += n;

                    if (num > 90)
                        num += 6;

                    if (num > 122)
                        num -= 58;

                    if (i % 2 != 0)
                        item = char.ToLower((char)num);
                    else
                        item = char.ToUpper((char)num);
                }
                else if (char.IsDigit(item))
                {
                    var num = item - 48;
                    num = 9 - num;
                    item = (char)(num + 48);
                }

                result.Add(item);
            }
            result.Reverse();

            return new string(result.ToArray());
        }
    }
}
