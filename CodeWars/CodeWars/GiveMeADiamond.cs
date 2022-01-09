using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5503013e34137eeeaa001648/train/csharp"/>
    /// TODO : 이게 왜 시간걸리지? Abs로 다시 풀어보기

    [TestClass]
    public class GiveMeADiamond
    {
        [TestMethod]
        public void Test()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.AreEqual(expected.ToString(), print(5));
        }

        public static string print(int n)
        {
            if (n % 2 == 0 || n < 0)
                return null;
            
            var diamond = new StringBuilder();

            var half = n / 2;

            for (var i = 0; i < half; i++)
            {
                for (var j = half - i; j > 0; j--)
                    diamond.Append(" ");

                for (var k = 0; k < i * 2 + 1; k++)
                    diamond.Append("*");

                diamond.Append("\n");
            }

            for (var i = 0; i < n; i++)
                diamond.Append("*");
            
            diamond.Append("\n");
            
            for (var i = 0; i < half; i++)
            {
                for (var j = 0; j < i + 1; j++)
                    diamond.Append(" ");

                for (int k = 0; k < n - 2 * (i + 1); k++)
                    diamond.Append("*");

                diamond.Append("\n");
            }

            return diamond.ToString();
        }
    }
}
