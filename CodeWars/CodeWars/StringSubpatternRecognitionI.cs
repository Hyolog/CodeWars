using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a49f074b3bfa89b4c00002b/train/csharp"/>
    [TestClass]
    public class StringSubpatternRecognitionI
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(false, HasSubpattern("a"));
            Assert.AreEqual(true, HasSubpattern("aaaa"));
            Assert.AreEqual(false, HasSubpattern("abcd"));
            Assert.AreEqual(true, HasSubpattern("abababab"));
            Assert.AreEqual(false, HasSubpattern("ababababa"));
            Assert.AreEqual(true, HasSubpattern("123a123a123a"));
            Assert.AreEqual(false, HasSubpattern("123A123a123a"));
            Assert.AreEqual(true, HasSubpattern("abbaabbaabba"));
            Assert.AreEqual(false, HasSubpattern("abbabbabba"));
            Assert.AreEqual(false, HasSubpattern("abcdabcabcd"));
        }

        public static bool HasSubpattern(string str)
        {
            int length = str.Length;

            for (int i = 1; i <= length / 2; i++)
            {
                if (length % i == 0)
                {
                    string pattern = str.Substring(0, i);
                    bool isSubpattern = true;

                    for (int j = i; j < length; j += i)
                    {
                        if (str.Substring(j, i) != pattern)
                        {
                            isSubpattern = false;
                            break;
                        }
                    }

                    if (isSubpattern)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
