using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5b4070144d7d8bbfe7000001/train/csharp"/>
    [TestClass]
    public class NumericalsOfAString
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("11121111213112111131224132411122", Numericals("Hello, World! It's me, JomoPipi!"));
            Assert.AreEqual("1112111121311", Numericals("Hello, World!"));
            Assert.AreEqual("11121122342", Numericals("hello hello"));
        }

        public static string Numericals(string s)
        {
            var dic = new Dictionary<char, int>();
            var result = new StringBuilder();

            foreach (var item in s)
            {
                if (dic.TryGetValue(item, out var count))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }

                result.Append(dic[item]);
            }

            return result.ToString();
        }
    }
}
