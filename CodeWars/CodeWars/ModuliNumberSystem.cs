using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54db15b003e88a6a480000b9/train/csharp"/>
    [TestClass]
    public class ModuliNumberSystem
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("-3--5--2--1-", ModSystem.fromNb2Str(187, new int[] { 8, 7, 5, 3 }));
            Assert.AreEqual("-1--2--1-", ModSystem.fromNb2Str(11, new int[] { 2, 3, 5 }));
            Assert.AreEqual("-1--2--3-", ModSystem.fromNb2Str(23, new int[] { 2, 3, 5 }));
            Assert.AreEqual("Not applicable", ModSystem.fromNb2Str(6, new int[] { 2, 3, 4 }));
            Assert.AreEqual("Not applicable", ModSystem.fromNb2Str(7, new int[] { 2, 3 }));
            Assert.AreEqual("-0--0--0-", ModSystem.fromNb2Str(1001, new int[] { 7, 11, 13 }));
        }
    }

    public class ModSystem
    {
        public static string fromNb2Str(int n, int[] sys)
        {
            if (!IsValidInput(n, sys))
                return "Not applicable";

            var residues = new List<int>();

            foreach (var item in sys)
                residues.Add(n % item);

            return $"-{string.Join("--", residues)}-";
        }

        private static bool IsValidInput(int number, int[] numbers)
        {
            return IsPairwiseCoPrime(numbers) && numbers.Aggregate((a, b) => a * b) >= number;
        }

        private static bool IsPairwiseCoPrime(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!IsCoPrime(numbers[i], numbers[j]))
                        return false;
                }
            }

            return true;
        }

        private static bool IsCoPrime(int value1, int value2)
        {
            return GetGCDByModulus(value1, value2) == 1;
        }

        public static int GetGCDByModulus(int value1, int value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                    value1 %= value2;
                else
                    value2 %= value1;
            }

            return Math.Max(value1, value2);
        }
    }
}
