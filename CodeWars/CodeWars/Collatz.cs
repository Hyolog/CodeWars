using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5286b2e162056fd0cb000c20/train/csharp"/>
    [TestClass]
    public class Collatz
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("3->10->5->16->8->4->2->1", CollatzFunc(3));
        }

        public static string CollatzFunc(int n)
        {
            var history = new List<int>() { n };

            while (n > 1)
            {
                n = n % 2 == 0 ? n / 2 : n * 3 + 1;
                history.Add(n);
            }

            return string.Join("->", history);
        }
    }
}
