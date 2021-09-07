using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55c6126177c9441a570000cc"/>
    [TestClass]
    public class WeightForWeight
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("2000 103 123 4444 99", orderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }

        public string orderWeight(string strng)
        {
            var result = new List<KeyValuePair<int, string>>();

            foreach (var number in strng.Split(' '))
            {
                var sum = 0;

                foreach (var digit in number)
                    sum += int.Parse(digit.ToString());

                result.Add(new KeyValuePair<int, string>(sum, number));
            }

            return string.Join(' ', result.OrderBy(d => d.Key).ThenBy(d => d.Value).Select(d => d.Value));
        }
    }
}
