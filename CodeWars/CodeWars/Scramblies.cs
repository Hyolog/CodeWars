using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55c04b4cc56a697bb0000048/train/csharp"/>
    [TestClass]
    public class Scramblies
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Scramble("rkqodlw", "world"), true);
            Assert.AreEqual(Scramble("cedewaraaossoqqyt", "codewars"), true);
            Assert.AreEqual(Scramble("katas", "steak"), false);
            Assert.AreEqual(Scramble("scriptjavx", "javascript"), false);
            Assert.AreEqual(Scramble("scriptingjava", "javascript"), true);
            Assert.AreEqual(Scramble("scriptsjava", "javascripts"), true);
            Assert.AreEqual(Scramble("javscripts", "javascript"), false);
            Assert.AreEqual(Scramble("aabbcamaomsccdd", "commas"), true);
            Assert.AreEqual(Scramble("commas", "commas"), true);
            Assert.AreEqual(Scramble("sammoc", "commas"), true);
        }

        public bool Scramble(string str1, string str2)
        {
            str1 = new string(str1.OrderBy(d => d).ToArray());
            str2 = new string(str2.OrderBy(d => d).ToArray());

            var str2Index = 0;

            foreach (var item in str1)
            {
                if (item.Equals(str2[str2Index]))
                    str2Index++;

                if (str2Index == str2.Length)
                    return true;
            }

            return false;
        }

        // best solution
        //public static bool Scramble(string str1, string str2)
        //{
        //    return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
        //}
    }
}
