using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5418a1dd6d8216e18a0012b2/train/csharp"/>
    [TestClass]
    public class ValidateCreditCardNumber
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, validate("6507 4670 35133"));

            Assert.AreEqual(false, validate("477 073 360"));
            Assert.AreEqual(true, validate("5422 0148 5514"));
            Assert.AreEqual(true, validate("8314 7046 0245"));
            Assert.AreEqual(false, validate("6654 6310 43044"));
            Assert.AreEqual(true, validate("0768 2757 5685 6340"));
            Assert.AreEqual(false, validate("7164 6207 74042"));
            Assert.AreEqual(true, validate("8383 7332 3570 8514"));
            Assert.AreEqual(true, validate("481 135"));
            Assert.AreEqual(true, validate("355 032 5363"));
        }

        public bool validate(string n)
        {
            // �����ʺ��� �����ؼ� ¦����° �� �� �� �ι� �Ѵ�.
            // ���� 9�� �Ѿ�� �ڸ��� ������ �ٲ۴� (ex 18 -> 9)
            // �� �ڸ��� ���� ���Ѵ�.
            // 10���� ������ �������� valid

            Console.WriteLine($"n : {n}");
            n = n.Replace(" ","");
            var result = 0;

            for (var i = n.Length - 2; i >= 0; i -= 2)
            {
                var number = int.Parse(n[i].ToString()) * 2;

                if (number > 9)
                    result += (number - 9);
                else
                    result += number;
            }

            for (var i = n.Length - 1; i >= 0; i -= 2)
            {
                var number = int.Parse(n[i].ToString());
                result += number;
            }

            return result % 10 == 0;
        }
    }
}
