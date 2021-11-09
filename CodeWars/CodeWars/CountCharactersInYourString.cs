using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp"/>
    [TestClass]
    public class CountCharactersInYourString
    {
        [TestMethod]
        public void Test()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            CollectionAssert.AreEqual(d, Count("aaaa"));
        }

        public Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(d => d).ToDictionary(e => e.Key, e => e.Count());
        }
    }
}
