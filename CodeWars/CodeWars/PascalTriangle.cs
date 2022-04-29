using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5226eb40316b56c8d500030f/train/csharp"/>
    [TestClass]
    public class PascalTriangle
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new List<int> { 1 }, PascalsTriangle(1));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1 }, PascalsTriangle(2));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, PascalsTriangle(4));
        }

        public static List<int> PascalsTriangle(int n)
        {
            if (n < 1)
                return null;
            else if (n == 1)
                return new List<int>() { 1 };
            else
            {
                var result = new List<int>();
                var lastRow = new List<int>();

                for (int rowIndex = 1; rowIndex <= n; rowIndex++)
                {
                    var currentLow = new List<int>();

                    for (int columnIndex = 0; columnIndex < rowIndex; columnIndex++)
                    {
                        if (columnIndex == 0)
                            currentLow.Add(1);
                        else if (columnIndex == rowIndex - 1)
                            currentLow.Add(1);
                        else 
                            currentLow.Add(lastRow[columnIndex - 1] + lastRow[columnIndex]);
                    }

                    result.AddRange(currentLow);
                    lastRow = currentLow;
                }

                return result;
            }
        }
    }
}
