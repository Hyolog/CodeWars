using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5894318275f2c75695000146/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기. hint : MAX()
    [TestClass]
    public class SimpleFun79DeleteADigit
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(52, DeleteDigit(152));
            Assert.AreEqual(101, DeleteDigit(1001));
            Assert.AreEqual(1, DeleteDigit(10));
            Assert.AreEqual(55568, DeleteDigit(555068));
            Assert.AreEqual(99958, DeleteDigit(909958));
            Assert.AreEqual(4699, DeleteDigit(14699));
            Assert.AreEqual(32530, DeleteDigit(132530));
            Assert.AreEqual(43641, DeleteDigit(243641));
            Assert.AreEqual(33480, DeleteDigit(333480));
        }

        public int DeleteDigit(int n)
        {
            var stringNum = n.ToString();
            var tempResult = "";

            for (int i = 0; i < stringNum.Length - 1; i++)
            {
                if (stringNum[i] < stringNum[i + 1])
                {
                    tempResult = stringNum.Remove(i, 1);

                    return int.Parse(tempResult);
                }
            }

            tempResult = stringNum.Remove(stringNum.Length - 1, 1);

            return int.Parse(tempResult);
        }
    }
}
