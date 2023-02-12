using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58a664bb586e986c940001d5/train/csharp"/>
    [TestClass]
    public class SimpleFunMissingAlphabets
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("z", MissingAlphabets("abcdefghijklmnopqrstuvwxy"));
            Assert.AreEqual("", MissingAlphabets("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual("zz", MissingAlphabets("aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy"));
            Assert.AreEqual("ayzz", MissingAlphabets("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxy"));
            Assert.AreEqual("bfghijklmnpqtuvxyz", MissingAlphabets("codewars"));
        }

        public string MissingAlphabets(string s)
        {
            var tempDic = new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'b', 0 },
                { 'c', 0 },
                { 'd', 0 },
                { 'e', 0 },
                { 'f', 0 },
                { 'g', 0 },
                { 'h', 0 },
                { 'i', 0 },
                { 'j', 0 },
                { 'k', 0 },
                { 'l', 0 },
                { 'm', 0 },
                { 'n', 0 },
                { 'o', 0 },
                { 'p', 0 },
                { 'q', 0 },
                { 'r', 0 },
                { 's', 0 },
                { 't', 0 },
                { 'u', 0 },
                { 'v', 0 },
                { 'w', 0 },
                { 'x', 0 },
                { 'y', 0 },
                { 'z', 0 }
            };

            foreach (var word in s)
            {
                tempDic[word]++;
            }

            var max = tempDic.Max(item => item.Value);
            var result = new StringBuilder();

            foreach (var item in tempDic)
            {
                var value = item.Value;

                for (int i = 0; i < max - value; i++)
                {
                    result.Append(item.Key);
                }
            }

            return result.ToString();
        }
    }
}
