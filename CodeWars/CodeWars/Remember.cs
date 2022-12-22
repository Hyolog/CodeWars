using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55a243393fb3e87021000198/train/csharp"/>
    [TestClass]
    public class Remember
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(RememberFunc("apple"), new List<char> { 'p' });
            CollectionAssert.AreEqual(RememberFunc("limbojackassin the garden"), new List<char> { 'a', 's', 'i', ' ', 'e', 'n' });
            CollectionAssert.AreEqual(RememberFunc("11pinguin"), new List<char> { '1', 'i', 'n' });
        }

        public static List<char> RememberFunc(string str)
        {
            var dic = new Dictionary<char, bool>();
            var result = new List<char>();

            foreach (var item in str)
            {
                if (dic.ContainsKey(item))
                {
                    if (!result.Contains(item))
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    dic.Add(item, false);
                }
            }

            return result;
        }
    }
}
