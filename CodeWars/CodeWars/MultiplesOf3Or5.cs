using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/514b92a657cdc65150000006/csharp"/>
    [TestClass]
    public class MultiplesOf3Or5
    {
        [TestMethod]
        public void Test()
        {
        }

        public static int Solution(int value)
        {
            return GetSumOfMultiples(3, value) + GetSumOfMultiples(5, value) - GetSumOfMultiples(15, value);
        }

        public static int GetSumOfMultiples(int value, int limit)
        {
            int tempNum = value;
            int resultNum = 0;

            while (tempNum < limit)
            {
                resultNum += tempNum;
                tempNum += value;
            }

            return resultNum;
        }
    }
}