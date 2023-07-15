using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56b5dc75d362eac53d000bc8/train/csharp"/>
    [TestClass]
    public class Basics03StringsNumbersAndCalculation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("47", calculateString(";$%¡×fsdfsd235??df/sdfgf5gh.000kk0000"));
            Assert.AreEqual("54929268", calculateString("sdfsd23454sdf*2342"));
            Assert.AreEqual("-210908", calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
            Assert.AreEqual("234676", calculateString("fsdfsd234.4554s4234df+sf234442"));
        }

        public string calculateString(string calcIt)
        {
            var temp = calcIt.Split('*', '/', '+', '-').Select(x => string.Concat(x.ToCharArray().Where(y => char.IsDigit(y) || y == '.'))).ToArray();
            
            double result;

            if (calcIt.Contains('*'))
                result = (double.Parse(temp[0]) * double.Parse(temp[1]));
            else if (calcIt.Contains('/'))
                result = (double.Parse(temp[0]) / double.Parse(temp[1]));
            else if (calcIt.Contains('+'))
                result = (double.Parse(temp[0]) + double.Parse(temp[1]));
            else if (calcIt.Contains('-'))
                result = (double.Parse(temp[0]) - double.Parse(temp[1]));
            else
                result = 0;

            return Convert.ToInt64(result).ToString();
        }
    }
}
