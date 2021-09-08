using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/523a86aa4230ebb5420001e1"/>
    [TestClass]
    public class WhereMyAnagramsAt
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new List<string> { "a" }, Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            CollectionAssert.AreEqual(new List<string> { "carer", "arcre", "carre" }, Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }

        public List<string> Anagrams(string word, List<string> words)
        {
            var result = new List<string>();

            word = new string(word.OrderBy(d => d).ToArray());

            foreach (var item in words)
            {
                var orderedItem = new string(item.OrderBy(d => d).ToArray());

                if (orderedItem.Equals(word))
                    result.Add(item);
            }

            return result;
        }
    }
}
