using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5768b217b8ed4a77c0000c46/train/csharp"/>
    [TestClass]
    public class NthUuser
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("1", UserNumber(1));
            Assert.AreEqual("5", UserNumber(4));
            Assert.AreEqual("10", UserNumber(8));
            Assert.AreEqual("12", UserNumber(10));
            Assert.AreEqual("25", UserNumber(20));
            Assert.AreEqual("875", UserNumber(500));
            Assert.AreEqual("1860", UserNumber(1000));
            Assert.AreEqual("303250", UserNumber(100000));
        }

        public static string UserNumber(int n)
        {
            int count = 0;
            int number = 0;

            while (count < n)
            {
                number++;
                if (!ContainsInvalidDigits(number))
                {
                    count++;
                }
            }

            return number.ToString();
        }

        private static bool ContainsInvalidDigits(int number)
        {
            string numberStr = number.ToString();
            return numberStr.Contains('4') || numberStr.Contains('9');
        }
    }
}
