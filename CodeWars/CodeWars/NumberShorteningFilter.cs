using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56b4af8ac6167012ec00006f/train/csharp"/>
    [TestClass]
    public class NumberShorteningFilter
    {
        [TestMethod]
        public void Test()
        {
            var filter = ShortenNumberCreator(new string[] { "", "k", "m" }, 1000);

            if (filter == null)
            {
                Assert.Fail("No method to invoke!");
            }

            Assert.AreEqual("234k", filter("234324"));
            Assert.AreEqual("98m", filter("98234324"));
            Assert.AreEqual("1,2,3", filter(new int[] { 1, 2, 3 }));
            Assert.AreEqual("", filter(""));
            Assert.AreEqual("32424m", filter("32424234223"));
        }

        public static Func<object, string> ShortenNumberCreator(string[] suffixes, int baseValue)
        {
            return (obj) =>
            {
                if (obj is int[])
                {
                    return string.Join(",", obj as int[]);
                }

                double number;
                if (!double.TryParse(obj.ToString(), out number))
                    return obj.ToString();

                int index = 0;
                while (number >= baseValue && index < suffixes.Length - 1)
                {
                    number /= baseValue;
                    index++;
                }

                return $"{Math.Truncate(number)}{suffixes[index]}";
            };
        }
    }
}
