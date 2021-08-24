using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55031bba8cba40ada90011c4/train/csharp"/>
    /// 6kyu 맞아? 고려할게 많은데? (재밌거나 좋은 문제같진 않음)
    [TestClass]
    public class HiddenCubicNumbers
    {
        [TestMethod]
        public void GetNumbersTest()
        {
            CollectionAssert.AreEqual(Cubes.GetNumbers("0 9026315 -827&()"), new List<string>() { "0", "902", "631", "5", "827" });
            CollectionAssert.AreEqual(Cubes.GetNumbers("aqdf&0#1xyz!22[153(777.777"), new List<string>() { "0", "1", "22", "153", "777", "777" });
            CollectionAssert.AreEqual(Cubes.GetNumbers("QK29a45[&erui9026315"), new List<string>() { "29", "45", "902", "631", "5" });
        }

        [TestMethod]
        public void IsCubicNumberTest()
        {
            Assert.AreEqual(Cubes.IsCubicNumber("902"), false);
            Assert.AreEqual(Cubes.IsCubicNumber("631"), false);
            Assert.AreEqual(Cubes.IsCubicNumber("153"), true);
            Assert.AreEqual(Cubes.IsCubicNumber("0"), true);
            Assert.AreEqual(Cubes.IsCubicNumber("1"), true);
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Cubes.IsSumOfCubes("0 9026315 -827&()"), "0 0 Lucky");
            Assert.AreEqual(Cubes.IsSumOfCubes("aqdf&0#1xyz!22[153(777.777"), "0 1 153 154 Lucky");
            Assert.AreEqual(Cubes.IsSumOfCubes("QK29a45[&erui9026315"), "Unlucky");
        }
    }

    public class Cubes
    {
        public static string IsSumOfCubes(string s)
        {
            var numbers = GetNumbers(s);
            List<int> cubicNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (IsCubicNumber(number))
                {
                    cubicNumbers.Add(Convert.ToInt32(number));
                }
            }

            return cubicNumbers.Any() ? $"{string.Join(" ", cubicNumbers)} {cubicNumbers.Sum()} Lucky" : "Unlucky";
        }

        public static List<string> GetNumbers(string s)
        {
            var numbers = new List<string>();
            string tempNumber = string.Empty;

            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                {
                    if (tempNumber.Length > 0)
                    {
                        numbers.Add(tempNumber);
                    }

                    tempNumber = string.Empty;
                }
                else
                {
                    tempNumber += item; 
                    
                    if (tempNumber.Length == 3)
                    {
                        numbers.Add(tempNumber);
                        tempNumber = string.Empty;
                    }
                }
            }

            if (tempNumber.Length > 0)
                numbers.Add(tempNumber);

            return numbers;
        }

        public static bool IsCubicNumber(string number)
        {
            var num = Convert.ToInt32(number);

            if (num < 0 || num > 999)
                return false;

            var tempNumber = 0;

            foreach (var item in number)
            {
                tempNumber += (int)Math.Pow(Convert.ToDouble(item.ToString()), 3);
            }

            return tempNumber == num ? true : false;
        }
    }
}
