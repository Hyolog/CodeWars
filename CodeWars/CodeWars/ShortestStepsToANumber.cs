using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5cd4aec6abc7260028dcd942/train/csharp"/>
    [TestClass]
    public class ShortestStepsToANumber
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, ShortestStepsToNum(1));
            Assert.AreEqual(4, ShortestStepsToNum(12));
            Assert.AreEqual(4, ShortestStepsToNum(16));
            Assert.AreEqual(9, ShortestStepsToNum(71));
        }

        public static int ShortestStepsToNum(int num)
        {
            var result = 0;

            while (num > 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;

                result++;
            }

            return result;
        }
    }
}
