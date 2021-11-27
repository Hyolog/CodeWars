using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/51e0007c1f9378fa810002a9/train/csharp"/>
    [TestClass]
    public class MakeTheDeadfishSwim
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 8, 64 }, Parse("iiisdoso"));
            CollectionAssert.AreEqual(new int[] { 8, 64, 3600 }, Parse("iiisdosodddddiso"));
        }

        public int[] Parse(string data)
        {
            var result = new List<int>();

            var number = 0;

            foreach (var item in data)
            {
                switch (item)
                {
                    case 'i': number++; break;
                    case 'd': number--; break;
                    case 's': number *= number;  break;
                    case 'o': result.Add(number); break;
                }
            }

            return result.ToArray();
        }
    }
}
