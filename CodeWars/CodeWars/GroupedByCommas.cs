using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5274e122fc75c0943d000148/train/csharp"/>
    [TestClass]
    public class GroupedByCommas
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(GroupByCommas(1234567890), "1,234,567,890");
            Assert.AreEqual(GroupByCommas(1), "1");
            Assert.AreEqual(GroupByCommas(1234), "1,234");
            Assert.AreEqual(GroupByCommas(12345), "12,345");
            Assert.AreEqual(GroupByCommas(12345678), "12,345,678");
            Assert.AreEqual(GroupByCommas(1234567890), "1,234,567,890");
        }

        public static string GroupByCommas(int n)
        {
            return string.Format("{0:n0}", n);
        }
    }
}
