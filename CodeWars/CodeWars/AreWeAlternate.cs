using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59325dc15dbb44b2440000af/train/csharp"/>
    [TestClass]
    public class AreWeAlternate
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, IsAlt("amazon"));
            Assert.AreEqual(false, IsAlt("apple"));
            Assert.AreEqual(true, IsAlt("banana"));
            Assert.AreEqual(false, IsAlt("hbdag"));
            Assert.AreEqual(false, IsAlt("ggihh"));
            Assert.AreEqual(false, IsAlt("cceji"));
            Assert.AreEqual(false, IsAlt("jbefj"));
            Assert.AreEqual(false, IsAlt("bfdfa"));
            Assert.AreEqual(false, IsAlt("aidjf"));
            Assert.AreEqual(false, IsAlt("edaii"));
        }

        public static bool IsAlt(string word)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var isStartFromVowel = vowels.Contains(word[0]);

            if (isStartFromVowel)
            {
                for (int i = 0; i < word.Length; i += 2)
                {
                    if (!vowels.Contains(word[i]))
                        return false;
                }

                for (int i = 1; i < word.Length; i += 2)
                {
                    if (vowels.Contains(word[i]))
                        return false;
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i += 2)
                {
                    if (vowels.Contains(word[i]))
                        return false;
                }

                for (int i = 1; i < word.Length; i += 2)
                {
                    if (!vowels.Contains(word[i]))
                        return false;
                }
            }

            return true;
        }
    }
}
