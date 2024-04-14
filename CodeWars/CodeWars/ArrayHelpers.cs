using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/525d50d2037b7acd6e000534/train/csharp"/>
    [TestClass]
    public class ArrayHelpers
    {
        int[] array = new[] { 1, 2, 3, 4, 5 };

        [TestMethod]
        public void Test()
        {
            //CollectionAssert.AreEqual(new[] { 1, 4, 9, 16, 25 }, array.Square(), "Square should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            //Assert.IsTrue(array.Square() is int[], "Square should return an array");

            //CollectionAssert.AreEqual(new[] { 1, 8, 27, 64, 125 }, array.Cube(), "Cube should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            //Assert.IsTrue(array.Cube() is int[], "Cube should return an array");

            //Assert.AreEqual(15, array.Sum(), "Sum should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");

            //Assert.AreEqual(3, array.Average(), "Average should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");

            //CollectionAssert.AreEqual(new[] { 2, 4 }, array.Even(), "Even should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            //Assert.IsTrue(array.Even() is int[], "Even should return an array");

            //CollectionAssert.AreEqual(new[] { 1, 3, 5 }, array.Odd(), "Odd should work correctly");
            //CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            //Assert.IsTrue(array.Odd() is int[], "Odd should return an array");
        }
    }

    static class Extensions
    {
        //public static int[] Square(this int[] str)
        //{
        //    var result = new int[str.Length];

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        result[i] = (int)Math.Pow(str[i], 2);
        //    }

        //    return result;
        //}

        //public static int[] Cube(this int[] str)
        //{
        //    var result = new int[str.Length];

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        result[i] = (int)Math.Pow(str[i], 3);
        //    }

        //    return result;
        //}

        //public static double Average(this int[] str)
        //{
        //    if (str.Length == 0)
        //        return double.NaN;

        //    double sum = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        sum += str[i];
        //    }

        //    return sum / str.Length;
        //}

        //public static int Sum(this int[] str)
        //{
        //    var sum = 0;

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        sum += str[i];
        //    }

        //    return sum;
        //}

        //public static int[] Even(this int[] str)
        //{
        //    var result = new List<int>();

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] % 2 == 0)
        //        {
        //            result.Add(str[i]);
        //        }
        //    }

        //    return result.ToArray();
        //}

        //public static int[] Odd(this int[] str)
        //{
        //    var result = new List<int>();

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] % 2 == 1)
        //        {
        //            result.Add(str[i]);
        //        }
        //    }

        //    return result.ToArray();
        //}
    }
}
