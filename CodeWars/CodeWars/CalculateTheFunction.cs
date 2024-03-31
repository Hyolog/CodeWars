using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54784a99b5339e1eaf000807/train/csharp"/>
    [TestClass]
    public class CalculateTheFunction
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(GetFunction(new[] { 0, 1, 2, 3, 4 })(5) == 5);
            Assert.IsTrue(GetFunction(new[] { 0, 3, 6, 9, 12 })(10) == 30);
            Assert.IsTrue(GetFunction(new[] { 1, 4, 7, 10, 13 })(20) == 61);
        }

        public static Func<int, int> GetFunction(int[] sequence)
        {
            var m = sequence[0];
            var n = sequence[1] - sequence[0];

            Func<int, int> func = x => n * x + m;

            for (var i = 2; i < 5; i++)
            {
                if (!IsValid(func, i, sequence[i]))
                {
                    throw new ArgumentException();
                }
            }

            return func;
        }

        private static bool IsValid(Func<int, int> func, int num, int result)
        {
            return result == func(num);
        }
    }
}