using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54d512e62a5e54c96200019e"/>
    [TestClass]
    public class PrimesInNumbers
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("(2**5)(5)(7**2)(11)", Factors(86240));
            Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", Factors(7775460));
        }

        public string Factors(int lst)
        {
            var result = new StringBuilder();

            for (var factor = 2; factor <= lst; factor++)
            {
                var pow = 0;

                while (lst % factor == 0)
                {
                    lst /= factor;
                    pow++;
                }

                if (pow > 1)
                    result.Append($"({factor}**{pow})");
                else if (pow == 1)
                    result.Append($"({factor})");
            }

            return result.ToString();
        }
    }
}
