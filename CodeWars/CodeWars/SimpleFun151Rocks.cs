using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58acf6c20b3b251d6d00002d/train/csharp"/>
    [TestClass]
    public class SimpleFun151Rocks
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(11, Rocks(10));
            Assert.AreEqual(4, Rocks(4));
            Assert.AreEqual(17, Rocks(13));
            Assert.AreEqual(277872985, Rocks(36123011));
        }

        /// <param name="n"> 1 ~ 10^9 </param>
        public long Rocks(long n)
        {
            long result = 0;

            var groups = new Dictionary<byte, long>()
            {
                { 1, (long)(Math.Pow(10, 1) - Math.Pow(10, 0)) },
                { 2, (long)(Math.Pow(10, 2) - Math.Pow(10, 1)) },
                { 3, (long)(Math.Pow(10, 3) - Math.Pow(10, 2)) },
                { 4, (long)(Math.Pow(10, 4) - Math.Pow(10, 3)) },
                { 5, (long)(Math.Pow(10, 5) - Math.Pow(10, 4)) },
                { 6, (long)(Math.Pow(10, 6) - Math.Pow(10, 5)) },
                { 7, (long)(Math.Pow(10, 7) - Math.Pow(10, 6)) },
                { 8, (long)(Math.Pow(10, 8) - Math.Pow(10, 7)) },
                { 9, (long)(Math.Pow(10, 9) - Math.Pow(10, 8)) },
                { 10,  (long)Math.Pow(10, 9) }
            };

            for (byte i = 9; i >= 1; i--)
            {
                if (Math.Pow(10, i - 1) <= n && n < Math.Pow(10, i))
                {
                    for (byte j = 1; j <= i - 1; j++)
                    {
                        result += j * groups[j];
                    }

                    result += i * (n - ((long)Math.Pow(10, i - 1) - 1));
                }
            }

            return result;
        }
    }
}
