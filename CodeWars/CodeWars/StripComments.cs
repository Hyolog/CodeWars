using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/51c8e37cee245da6b40000bd/train/csharp"/>
    [TestClass]
    public class StripComments
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("apples, pears\ngrapes\nbananas", StripCommentsFunc("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
            Assert.AreEqual("a\nc\nd", StripCommentsFunc("a #b\nc\nd $e f g", new string[] { "#", "$" }));
        }

        public static string StripCommentsFunc(string text, string[] commentSymbols)
        {
            var lines = text.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                int index = lines[i].IndexOfAny(commentSymbols.Select(symbol => symbol[0]).ToArray());

                if (index != -1)
                {
                    lines[i] = lines[i].Substring(0, index);
                }

                lines[i] = lines[i].TrimEnd();
            }

            return string.Join("\n", lines);
        }
    }
}
