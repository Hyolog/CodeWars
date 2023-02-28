using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/51f1342c76b586046800002a/train/csharp"/>
    [TestClass]
    public class RoundBySteps
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Solution(4.8), 5);
        }

        public static double Solution(double n)
        {
            var num = (int)n;

            if (n - num < 0.25)
                return (double)num;
            else if (n - num >= 0.75)
                return num + 1;
            else
                return (double)num + 0.5;
        }
    }
}
