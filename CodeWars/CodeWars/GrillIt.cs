using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/595b3f0ad26b2d817400002a/train/csharp"/>
    [TestClass]
    public class GrillIt
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("df", Grille("abcdef", 5));
            Assert.AreEqual("", Grille("", 5));
            Assert.AreEqual("d", Grille("abcd", 1));
            Assert.AreEqual("b", Grille("0abd", 2));
            Assert.AreEqual("codewars", Grille("tcddoadepwweasresd", 77098));
        }

        public static string Grille(string message, int code)
        {
            var result = new StringBuilder();
            var binary = Convert.ToString(code, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                var item = int.Parse(binary[binary.Length - 1 - i].ToString());

                if (item == 1 && (message.Length - 1 - i) >= 0)
                {
                    result.Append(message[message.Length - 1 - i]);
                }
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
