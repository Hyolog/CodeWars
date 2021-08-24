using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54da5a58ea159efa38000836/csharp"/>
    [TestClass]
    public class FindTheOddInt
    {
        [TestMethod]
        public void Test()
        {
        }

        public static int find_it(int[] seq)
        {
            Dictionary<int, int> storage = new Dictionary<int, int>();

            foreach (var item in seq)
            {
                if (storage.ContainsKey(item))
                {
                    storage.Remove(item);
                }
                else
                {
                    storage.Add(item, item);
                }
            }

            return storage.First().Key;
        }
    }
}