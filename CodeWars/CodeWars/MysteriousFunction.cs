using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55217af7ecb43366f8000f76/train/csharp"/>
    [TestClass]
    public class MysteriousFunction
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(2, GetNum(300)); // 0 = 1
            Assert.AreEqual(4, GetNum(90783)); // 7 8 9 = 2
            Assert.AreEqual(0, GetNum(123321)); // 1 2 3 = 0
            Assert.AreEqual(8, GetNum(89282350306));
            Assert.AreEqual(6, GetNum(89856)); // 5 6 8 8 9 = 6
            Assert.AreEqual(5, GetNum(3479283469));
            Assert.AreEqual(5, GetNum(4798469)); // 4 4 6 7 8 9 9 = 5
        }

        public static int GetNum(long n)
        {
            int count = 0;

            while (n > 0)
            {
                int digit = (int)(n % 10);

                if (digit == 0 || digit == 6 || digit == 9)
                {
                    count++;
                }
                else if (digit == 8)
                {
                    count += 2;
                }

                n /= 10;
            }

            return count;
        }
    }
}
