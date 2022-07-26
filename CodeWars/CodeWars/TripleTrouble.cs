using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55d5434f269c0c3f1b000058/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class TripleTrouble
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(TripleDouble(451999277, 41177722899), 1);
            Assert.AreEqual(TripleDouble(1222345, 12345), 0);
            Assert.AreEqual(TripleDouble(12345, 12345), 0);
            Assert.AreEqual(TripleDouble(666789, 12345667), 1);
            Assert.AreEqual(TripleDouble(1112, 122), 0);
        }

        public static int TripleDouble(long num1, long num2)
        {
            var number = GetTriple(num1);

            if (number == -1)
                return 0;

            return IsExistDouble(number, num2);
        }

        private static int GetTriple(long number)
        {
            char pivot = default;
            byte count = 1;

            foreach (var item in number.ToString())
            {
                if (pivot.Equals(item))
                    count++;
                else
                {
                    pivot = item;
                    count = 1;
                }

                if (count >= 3)
                    return int.Parse(pivot.ToString());
            }

            return -1;
        }

        private static int IsExistDouble(long number, long number2)
        {
            var numberString = number2.ToString();

            for (int i = 0; i < numberString.Length - 1; i++)
            {
                var num = int.Parse(numberString[i].ToString());

                if (num == number)
                {
                    var nextNum = int.Parse(numberString[i + 1].ToString());

                    if (nextNum == number)
                        return 1;
                }
            }

            return 0;
        }

        // Linq풀이 참고
        //public static int TripleDouble(long num1, long num2)
        //{
        //    return "0123456789".Count(number => num1.ToString().Contains(new string(number, 3)) && num2.ToString().Contains(new string(number, 2)));
        //}
    }
}
