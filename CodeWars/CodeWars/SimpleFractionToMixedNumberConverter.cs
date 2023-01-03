using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/556b85b433fb5e899200003f/train/csharp"/>
    [TestClass]
    public class SimpleFractionToMixedNumberConverter
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("4 2/3", MixedFraction("42/9"));
            Assert.AreEqual("2", MixedFraction("6/3"));
            Assert.AreEqual("1", MixedFraction("1/1"));
            Assert.AreEqual("1", MixedFraction("11/11"));
            Assert.AreEqual("2/3", MixedFraction("4/6"));
            Assert.AreEqual("0", MixedFraction("0/18891"));
            Assert.AreEqual("-1 3/7", MixedFraction("-10/7"));
            Assert.AreEqual("3 1/7", MixedFraction("-22/-7"));
            Assert.AreEqual("1/9", MixedFraction("-1/-9"));
            Assert.AreEqual("-313/941", MixedFraction("313/-941"));
            Assert.AreEqual("-1 79/308", MixedFraction("-774/616"));
            Assert.AreEqual("3/8", MixedFraction("-12/-32"));
            Assert.AreEqual("179/220", MixedFraction("358/440"));
            Assert.AreEqual("-1 1/2", MixedFraction("-15/10"));
            Assert.AreEqual("-195595/564071", MixedFraction("-195595/564071"));
            Assert.AreEqual(typeof(DivideByZeroException), MixedFraction("0/0"));
        }

        public static string MixedFraction(string s)
        {
            Console.WriteLine(s);

            var split = s.Split('/').Select(d => int.Parse(d)).ToArray();

            if (split[1] == 0)
                throw new DivideByZeroException();
            else if (split[0] == 0)
                return "0";
            else if (split[1] == 1)
                return split[0].ToString();
            else if (split[0] == 1)
                return split[1] > 1 ? s : "1";

            var quotient = split[0] / split[1];
            split[0] -= (quotient * split[1]);

            if (split[0] == 0)
                return $"{quotient}";

            for (int i = 2; i <= Math.Min(Math.Abs(split[0]), Math.Abs(split[1])); i++)
            {
                if (split[0] % i == 0 && split[1] % i == 0)
                {
                    split[0] /= i;
                    split[1] /= i;
                    i = 1;
                }
            }

            if (split[1] < 0)
            {
                if (split[0] < 0)
                {
                    split[0] *= -1;
                    split[1] *= -1;
                }
                else
                {
                    split[1] *= -1;
                    split[0] *= -1;
                }
            }

            return quotient == 0 ? $"{split[0]}/{split[1]}" : $"{quotient} {Math.Abs(split[0])}/{Math.Abs(split[1])}";
        }
    }
}
