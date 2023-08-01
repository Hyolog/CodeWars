using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5fefee21b64cc2000dbfa875/train/csharp"/>
    [TestClass]
    public class SmallestPermutation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(-20, MinPermutation(-20));
            Assert.AreEqual(-23, MinPermutation(-32));
            Assert.AreEqual(0, MinPermutation(0));
            Assert.AreEqual(10, MinPermutation(10));
            Assert.AreEqual(23499, MinPermutation(29394));
        }

        public int MinPermutation(int n)
        {
            if (n == 0) return 0;

            var digits = Math.Abs(n).ToString().OrderBy(c => c).ToList();

            if (n > 0)
            {
                if (digits[0] == '0')
                {
                    var nonZeroDigit = digits.Find(d => d > '0');
                    digits.Remove(nonZeroDigit);
                    digits.Insert(0, nonZeroDigit);
                }

                return int.Parse(new string(digits.ToArray()));
            }
            else
            {
                var nonZeroDigit = digits.Find(d => d > '0');
                digits.Remove(nonZeroDigit);
                digits.Insert(0, nonZeroDigit);

                return -int.Parse(new string(digits.ToArray()));
            }
        }
    }
}
