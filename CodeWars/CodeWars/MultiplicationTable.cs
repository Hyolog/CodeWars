using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08"/>
    [TestClass]
    public class MultiplicationTable
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } }, MultiplicationTableFunc(3));
        }

        public static int[,] MultiplicationTableFunc(int size)
        {
            var result = new int[size, size];

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    result[i - 1, j - 1] = i * j;
                }
            }

            return result;
        }   
    }
}
