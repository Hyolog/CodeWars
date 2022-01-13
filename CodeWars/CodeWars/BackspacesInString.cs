using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/train/csharp"/>
    [TestClass]
    public class BackspacesInString
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("ac", CleanString("abc#d##c"));
            Assert.AreEqual("", CleanString("abc####d##c#"));
            Assert.AreEqual("", CleanString("abc####d##c#"));
        }

        public static string CleanString(string s)
        {
            var result = new Stack<char>();

            foreach (var item in s)
            {
                if (item.Equals('#') && result.Count > 0)
                    result.Pop();
                else
                    result.Push(item);
            }

            if (result.Count > 0 && result.Peek().Equals('#'))
                result.Pop();

            return new string(result.Reverse().ToArray());
        }
    }
}
