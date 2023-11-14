using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/589d74722cae97a7260000d9/train/csharp"/>
    [TestClass]
    public class SimpleFun121MrOdd
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, MrOdd("oudddbo"));
            Assert.AreEqual(1, MrOdd("ouddddbo"));
            Assert.AreEqual(2, MrOdd("ooudddbd"));
            Assert.AreEqual(6, MrOdd("qoddoldfoodgodnooofostorodrnvdmddddeidfoi"));
        }

        public int MrOdd(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'o')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == 'd')
                        {
                            for (int k = j + 1; k < s.Length; k++)
                            {
                                if (s[k] == 'd')
                                {
                                    count++;
                                    s = s.Substring(0, i) + '.' + s.Substring(i + 1, j - i - 1) + '.' + s.Substring(j + 1, k - j - 1) + '.' + s.Substring(k + 1);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
