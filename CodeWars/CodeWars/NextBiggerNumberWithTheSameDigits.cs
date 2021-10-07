using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55983863da40caa2c900004e/train/csharp"/>
    [TestClass]
    public class NextBiggerNumberWithTheSameDigits
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(483559, NextBiggerNumber(459853));
            Assert.AreEqual(123456798, NextBiggerNumber(123456789));
            Assert.AreEqual(1234567908, NextBiggerNumber(1234567890));
            Assert.AreEqual(-1, NextBiggerNumber(9876543210));
            Assert.AreEqual(-1, NextBiggerNumber(9999999999));
            Assert.AreEqual(194678, NextBiggerNumber(189764));
            Assert.AreEqual(21, NextBiggerNumber(12));
            Assert.AreEqual(531, NextBiggerNumber(513));
            Assert.AreEqual(2071, NextBiggerNumber(2017));
            Assert.AreEqual(441, NextBiggerNumber(414));
            Assert.AreEqual(414, NextBiggerNumber(144));
        }

        public long NextBiggerNumber(long n)
        {
            if (n < 10)
                return -1;

            var number = n.ToString();
            var index = number.Length - 1;
            var result = string.Empty;

            while (index > 0)
            {
                // 다음 자리수에 값이 작아지는 위치 찾으면
                if (number[index - 1] < number[index])
                {
                    // [0 ~ index - 1]까지 값 복사 (바뀌지 않는 구간)
                    result = number.Substring(0, index - 1);

                    var pivot = number[index - 1];

                    // [index - 1 ~ 끝] 오름차순 정렬
                    var tempString = new string(number.Substring(index - 1, number.Length - (index - 1)).OrderBy(d => d).ToArray());

                    // 정렬한 값에서 pivot보다 큰 값중 가장 작은 값 찾아서 result에 기록
                    for (int i = 0; i < tempString.Length; i++)
                    {
                        if (tempString[i] > pivot)
                        {
                            result += tempString[i];
                            tempString = tempString.Remove(i, 1);
                            break;
                        }
                    }

                    // 나머지 기록
                    result += tempString;


                    return Convert.ToInt64(result);
                }
                else
                    index--;
            }

            return -1;
        }
    }
}
