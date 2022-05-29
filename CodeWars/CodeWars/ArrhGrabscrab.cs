using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52b305bec65ea40fe90007a7/train/csharp"/>
    [TestClass]
    public class ArrhGrabscrab
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.Equals(Grabscrab("trisf", new List<string> { "first" }), new List<string> { "first" });
            CollectionAssert.Equals(Grabscrab("oob", new List<string> { "bob", "baobab" }), new List<string> { });
            CollectionAssert.Equals(Grabscrab("ainstuomn", new List<string> { "mountains", "hills", "mesa" }), new List<string> { "mountains" });
            CollectionAssert.Equals(Grabscrab("ortsp", new List<string> { "sport", "parrot", "ports", "matey" }),new List<string> { "sport", "ports" });
        }

        public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            var result = new List<string>();

            var pivot = new string(anagram.OrderBy(d => d).ToArray());

            foreach (var item in dictionary)
            {
                if (new string(item.OrderBy(d => d).ToArray()).Equals(pivot))
                    result.Add(item);
            }

            return result;
        }
    }
}
