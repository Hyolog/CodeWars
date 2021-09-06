using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp"/>
    [TestClass]
    public class SumOfDigitsDigitalRoot
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(7, DigitalRoot(16));
            Assert.AreEqual(6, DigitalRoot(456));
        }

        public int DigitalRoot(long n)
        {
            var stringNum = n.ToString();

            while (stringNum.Length > 1)
            {
                var sum = 0;

                foreach (var num in stringNum)
                    sum += int.Parse(num.ToString());

                stringNum = sum.ToString();
            }

            return int.Parse(stringNum);
        }
    }
}
