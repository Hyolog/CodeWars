using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55c45be3b2079eccff00010f/solutions/csharp"/>
    [TestClass]
    public class YourOrderPlease
    {
        [TestMethod]
        public void Test()
        {
        }

        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return string.Empty;

            return string.Join(' ', words.Split(' ').OrderBy(s => s.First(c => Char.IsDigit(c))));
        }
    }
}