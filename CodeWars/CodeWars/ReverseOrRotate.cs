using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56b5afb4ed1f6d5fb0000991/train/csharp"/>
    [TestClass]
    public class ReverseOrRotate
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(RevRot("1234", 0), "");
            Assert.AreEqual(RevRot("", 0), "");
            Assert.AreEqual(RevRot("1234", 5), "");
        }

        public static string RevRot(string strng, int sz)
        {
            if (sz <= 0 || string.IsNullOrEmpty(strng))
                return "";

            if (sz > strng.Length)
                return "";

            string result = "";
            for (int i = 0; i <= strng.Length - sz; i += sz)
            {
                string chunk = strng.Substring(i, sz);
                if (IsSumOfCubesDivisibleByTwo(chunk))
                    result += ReverseString(chunk);
                else
                    result += RotateLeft(chunk);
            }

            return result;
        }

        private static bool IsSumOfCubesDivisibleByTwo(string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                int digit = c - '0';
                sum += (digit * digit * digit);
            }

            return sum % 2 == 0;
        }

        private static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string RotateLeft(string str)
        {
            return str.Substring(1) + str[0];
        }
    }
}
