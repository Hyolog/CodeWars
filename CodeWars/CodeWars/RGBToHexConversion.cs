using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp"/>
    [TestClass]
    public class RGBToHexConversion
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("FFFFFF", Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Rgb(255, 255, 300));
            Assert.AreEqual("000000", Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }

        public string Rgb(int r, int g, int b)
        {
            r = Calibration(r);
            g = Calibration(g);
            b = Calibration(b);

            return Convert.ToString(r / 16, 16).ToUpper() + Convert.ToString(r % 16, 16).ToUpper() +
                Convert.ToString(g / 16, 16).ToUpper() + Convert.ToString(g % 16, 16).ToUpper() +
                Convert.ToString(b / 16, 16).ToUpper() + Convert.ToString(b % 16, 16).ToUpper();
        }

        public int Calibration(int number)
        {
            if (number < 0)
                return 0;
            else if (number > 255)
                return 255;
            else
                return number;
        }
    }
}
