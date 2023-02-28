using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/554a44516729e4d80b000012/train/csharp"/>
    [TestClass]
    public class BuyingACar
    {
        [TestMethod]
        public void Test()
        {
            int[] r = new int[] { 6, 766 };
            CollectionAssert.AreEqual(r, nbMonths(2000, 8000, 1000, 1.5));

            r = new int[] { 0, 4000 };
            CollectionAssert.AreEqual(r, nbMonths(12000, 8000, 1000, 1.5));

            r = new int[] { 0, 0 };
            CollectionAssert.AreEqual(r, nbMonths(8000, 8000, 1000, 1.5));
        }

        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            var gap = startPriceNew - startPriceOld;
            var month = 0;
            var cash = 0;
            double startNew = startPriceNew;
            double startOld = startPriceOld;


            while (startNew > (startOld + cash))
            {
                cash += savingPerMonth;

                startNew *= (1 - percentLossByMonth / 100);
                startOld *= (1 - percentLossByMonth / 100);

                if (month % 2 == 0)
                    percentLossByMonth += 0.5;

                month++;
            }

            return new int[] { month, (int)Math.Round(startOld + cash - startNew) };
        }
    }
}
