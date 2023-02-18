using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/565c4e1303a0a006d7000127/train/csharp"/>
    [TestClass]
    public class NumberFormat
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(NumberFormatFunc(100000), "100,000");
            Assert.AreEqual(NumberFormatFunc(5678545), "5,678,545");
        }

        public static string NumberFormatFunc(int number)
        {
            return string.Format("{0:N0}", number);
        }
    }
}
