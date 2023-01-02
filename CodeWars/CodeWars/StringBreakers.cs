using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59d398bb86a6fdf100000031/train/csharp"/>
    [TestClass]
    public class StringBreakers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Thisi" + "\n" + "sanex" + "\n" + "ample" + "\n" + "strin" + "\n" + "g", StringBreakersFunc(5, "This is an example string"));
        }

        public static string StringBreakersFunc(int n, string str)
        {
            str = str.Replace(" ", "");
            var index = 0;
            var result = new List<string>();

            while (str.Length - (index + 1) >= n)
            {
                var word = str.Substring(index, n);
                result.Add(word);
                index += n;
            }

            result.Add(str.Substring(index, str.Length - (index)));

            return string.Join("\n", result);
        }
    }
}
