using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56efab15740d301ab40002ee/train/csharp"/>
    [TestClass]
    public class ReducingBySteps
    {
        [TestMethod]
        public void Test()
        {
        }
    }

    public class Operarray
    {
        public static long gcdi(long x, long y)
        {
            return GCD(Math.Abs(x), Math.Abs(y));
        }
        public static long lcmu(long a, long b)
        {
            return LCM(Math.Abs(a), Math.Abs(b));
        }
        public static long som(long a, long b)
        {
            return a + b;
        }
        public static long maxi(long a, long b)
        {
            return Math.Max(a, b);
        }
        public static long mini(long a, long b)
        {
            return Math.Min(a, b);
        }
        public static long oper(Func<long, long, long> fct, long a, long b)
        {
            return fct(a, b);
        }
        public static long[] OperArray(Func<long, long, long> fct, long[] arr, long init)
        {
            long[] result = new long[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = fct(init, arr[i]);
                }
                else
                {
                    result[i] = fct(result[i - 1], arr[i]);
                }
            }

            return result;
        }

        static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static long LCM(long a, long b)
        {
            return (a / GCD(a, b)) * b;
        }
    }
}
