using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/6210fb7aabf047000f3a3ad6/train/csharp"/>
    /// 무작위테스트 버그있음
    [TestClass]
    public class AssembleString
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("abcde", Assemble(new string[] { "a*cde", "*bcde", "abc*e" }));
            Assert.AreEqual("a#cd#", Assemble(new string[] { "a*c**", "**cd*", "a*cd*" }));
            Assert.AreEqual("hashtag -> #", Assemble(new string[] { "*ashtag ** *", "h*sht*g *> *", "has*tag -* *" }));
            Assert.AreEqual("abcde", Assemble(new string[] { "abcde", "abcde", "abcde", "*****", "*****", "*****" }));
            Assert.AreEqual("abcde", Assemble(new string[] { "abcde", "abcde", "abcbe" }));
            Assert.AreEqual("#####", Assemble(new string[] { "*****", "*****", "*****" }));
            Assert.AreEqual("", Assemble(new string[0]));
            Assert.AreEqual("", Assemble(new string[] { "", "", "" }));
        }

        public static string Assemble(string[] copies)
        {
            if (copies.Length == 0)
                return "";

            var max = copies.Max(d => d.Length);

            var result = new char[max];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = '#';
            }

            foreach (var copy in copies)
            {
                for (int i = 0; i < copy.Length; i++)
                {
                    if (result[i] == '#' && copy[i] != '*')
                    {
                        result[i] = copy[i];
                    }
                }
            }

            return new string(result);
        }
    }
}
