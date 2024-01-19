using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/568d1ee43ee6afb3ad00001d/train/csharp"/>
    [TestClass]
    public class Modulus11CheckDigit
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("0365327", AddCheckDigit("036532"));
            Assert.AreEqual("1111111118", AddCheckDigit("111111111"));
        }

        public static string AddCheckDigit(string number)
        {
            var factor = 2;
            var result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                var digit = int.Parse(number[number.Length - 1 - i].ToString());
                result += digit * factor;

                if (factor >= 7)
                    factor = 2;
                else
                    factor++;
            }

            var mod = result % 11;

            if (mod == 0)
                return number + "0";
            else if (mod == 1)
                return number + "X";
            else
            {
                var num = 11 - mod;
                return number + $"{num}";
            }
        }
    }
}
