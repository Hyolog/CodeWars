using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59279aea8270cc30080000df/train/csharp"/>
    [TestClass]
    public class TheFreewayGame
    {
        [TestMethod]
        public void Test()
        {
            var count = FreewayGame(50.0, 130.0, new[] { (-1.0, 120.0), (-1.5, 120.0) });
            Assert.AreEqual(2, count);

            count = FreewayGame(50.0, 110.0, new[] { (1.0, 120.0), (1.5, 125.0) });
            Assert.AreEqual(-2, count);

            count = FreewayGame(50.0, 120.0, new[] { (-1.0, 115.0), (-1.5, 110.0), (1.0, 130.0), (1.5, 130.0) });
            Assert.AreEqual(0, count);

            count = FreewayGame(30.0, 100.0, new[] { (-1.0, 110.0), (-0.7, 102.0), (-1.5, 108.0) });
            Assert.AreEqual(0, count);

            count = FreewayGame(30.0, 130.0, new[] { (1.0, 120.0), (0.7, 125.0), (1.5, 110.0) });
            Assert.AreEqual(0, count);
        }

        public static int FreewayGame(double distKmToExit, double mySpeedKph, (double, double)[] otherCars)
        {
            double myExpectedHour = distKmToExit / mySpeedKph;
            int score = 0;

            foreach (var car in otherCars)
            {
                double carPosition = car.Item2 * (car.Item1 / 60);
                double carExpectedHour = (carPosition + distKmToExit) / car.Item2;

                // 뒤에있음
                if (carPosition > 0)
                {
                    // 역전당함
                    if (carExpectedHour < myExpectedHour)
                    {
                        score--;
                    }
                }
                else
                {
                    if (carExpectedHour > myExpectedHour)
                    {
                        score++;
                    }
                }
            }

            return score;
        }
    }
}
