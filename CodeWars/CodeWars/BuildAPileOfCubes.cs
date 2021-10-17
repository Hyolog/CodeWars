using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5592e3bd57b64d00f3000047/train/csharp"/>
    [TestClass]
    public class BuildAPileOfCubes
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, findNb(36));
            Assert.AreEqual(45, findNb(1071225));
            Assert.AreEqual(2022, findNb(4183059834009));
            Assert.AreEqual(-1, findNb(24723578342962));
            Assert.AreEqual(4824, findNb(135440716410000));
            Assert.AreEqual(3568, findNb(40539911473216));
        }

        public long findNb(long m)
        {
            var index = 0;

            while (m > 0)
            {
                m -= (long)Math.Pow(index, 3);
                index++;
            }

            return m == 0 ? index - 1 : -1;
        }
    }
}
