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
                // ���� �ڸ����� ���� �۾����� ��ġ ã����
                if (number[index - 1] < number[index])
                {
                    // [0 ~ index - 1]���� �� ���� (�ٲ��� �ʴ� ����)
                    result = number.Substring(0, index - 1);

                    var pivot = number[index - 1];

                    // [index - 1 ~ ��] �������� ����
                    var tempString = new string(number.Substring(index - 1, number.Length - (index - 1)).OrderBy(d => d).ToArray());

                    // ������ ������ pivot���� ū ���� ���� ���� �� ã�Ƽ� result�� ���
                    for (int i = 0; i < tempString.Length; i++)
                    {
                        if (tempString[i] > pivot)
                        {
                            result += tempString[i];
                            tempString = tempString.Remove(i, 1);
                            break;
                        }
                    }

                    // ������ ���
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
