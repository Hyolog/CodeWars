using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5254bd1357d59fbbe90001ec/train/csharp"/>
    [TestClass]
    public class SequencesAndSeries
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(50, GetScore(1), "GetScore(1) returns a wrong result");
            Assert.AreEqual(150, GetScore(2), "GetScore(2) returns a wrong result");
            Assert.AreEqual(300, GetScore(3), "GetScore(3) returns a wrong result");
            Assert.AreEqual(500, GetScore(4), "GetScore(4) returns a wrong result");
            Assert.AreEqual(750, GetScore(5), "GetScore(5) returns a wrong result");
        }

        public static long GetScore(long n)
        {
            // an = an-1 + (n+1)50
            return 50 + 50 * (n * (n + 1) / 2 - 1);
        }
    }
}
