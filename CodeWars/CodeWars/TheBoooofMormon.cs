using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58373ba351e3b615de0001c3/train/csharp"/>
    [TestClass]
    public class TheBoooofMormon
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, Mormons(10, 3, 9)); // No missions are needed because the number of followers already exceeds target
            Assert.AreEqual(1, Mormons(40, 2, 120));
            Assert.AreEqual(2, Mormons(40, 2, 121));
            Assert.AreEqual(12, Mormons(20000, 2, 7000000000)); // Mormons dominate the world!
        }

        public static long Mormons(long startingNumber, long reach, long target)
        {
            var result = 0;

            while (startingNumber < target)
            {
                startingNumber += startingNumber * reach;
                result++;
            }

            return result;
        }
    }
}
