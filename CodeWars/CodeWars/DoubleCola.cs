using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/551dd1f424b7a4cdae0001f0/train/csharp"/>
    [TestClass]
    public class DoubleCola
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Sheldon", WhoIsNext(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 1));
            Assert.AreEqual("Sheldon", WhoIsNext(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 6));
            Assert.AreEqual("Penny", WhoIsNext(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 52));
            Assert.AreEqual("Leonard", WhoIsNext(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 7230702951));
        }

        public string WhoIsNext(string[] names, long n)
        {
            long length = names.Length;
            long generation = 1;

            while (n > length)
            {
                n -= length;
                length *= 2;
                generation *= 2;
            }

            return (names[(n - 1) / generation]);
        }
    }
}
