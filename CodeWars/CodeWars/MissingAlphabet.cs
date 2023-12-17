using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5ad1e412cc2be1dbfb000016/train/csharp"/>
    [TestClass]
    public class MissingAlphabet
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZloPQRSTUVWXYZ", MissingAlphabet.InsertMissingLetters("hello"));
        }

        public static string InsertMissingLetters(string str)
        {
            str = str.ToUpper();
            
            var alphabet = Enumerable.Range('A', 26).Select(x => (char)x).Where(d => !str.Contains(d)).ToHashSet();

            string result = "";

            foreach (char c in str)
            {
                result += char.ToLower(c);

                if (result.Where(d => d.Equals(char.ToLower(c))).Count() < 2)
                {
                    foreach (char missingChar in alphabet.Where(x => x > c))
                    {
                        result += missingChar;
                    }
                }
            }

            return result;
        }
    }
}
