using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp"/>
    [TestClass]
    public class BouncingBalls
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, BouncingBall.bouncingBall(3.0, 0.66, 1.5));
            Assert.AreEqual(15, BouncingBall.bouncingBall(30.0, 0.66, 1.5));
        }
    }

    public class BouncingBall
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (!IsValidParameters(h, bounce, window))
                return -1;

            var bouncingCount = 0;

            while (h > window)
            {
                h *= bounce;

                if (h > window)
                    bouncingCount++;
            }

            return bouncingCount * 2 + 1;
        }

        private static bool IsValidParameters(double h, double bounce, double windowHeight)
        {
            return (h > 0) && (bounce > 0 && bounce < 1) && (windowHeight < h);
        }
    }
}
