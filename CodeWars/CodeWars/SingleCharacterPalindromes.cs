using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a2c22271f7f709eaa0005d3/train/csharp"/>
    [TestClass]
    public class SingleCharacterPalindromes
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("OK", solve("abba"));
            Assert.AreEqual("remove one", solve("abbaa"));
            Assert.AreEqual("not possible", solve("abbaab"));
            Assert.AreEqual("remove one", solve("madmam"));
            Assert.AreEqual("not possible", solve("raydarm"));
            Assert.AreEqual("OK", solve("hannah"));
        }

        public static string solve(string s)
        {
            var startIndex = 0;
            var lastIndex = s.Length - 1;
            var isFirst = true;

            while (startIndex < lastIndex)
            {
                if (s[startIndex] != s[lastIndex])
                {
                    if (isFirst)
                    {
                        isFirst = false;

                        if (startIndex + 1 == lastIndex)
                        {
                            return "remove one";
                        }
                        else if (s[startIndex + 1] == s[lastIndex])
                        {
                            startIndex++;
                        }
                        else if (s[startIndex] == s[lastIndex - 1])
                        {
                            lastIndex--;
                        }
                        else
                        {
                            return "not possible";
                        }
                    }
                    else
                    {
                        return "not possible";
                    }
                }
                else
                {
                    startIndex++;
                    lastIndex--;
                }
            }

            return isFirst ? "OK" : "remove one";

        }

    }
}
