using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/589d6bc33b368ea992000035/train/csharp"/>
    [TestClass]
    public class RangeCollapseRepresentation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(8, Descriptions(new int[] { 1, 3, 4, 5, 6, 8 }));
            Assert.AreEqual(4, Descriptions(new int[] { 1, 2, 3 }));
            Assert.AreEqual(1, Descriptions(new int[] { 11, 43, 66, 123 }));
            Assert.AreEqual(64, Descriptions(new int[] { 3, 4, 5, 8, 9, 10, 11, 23, 43, 66, 67 }));
        }

        public int Descriptions(int[] arr)
        {
            HashSet<string> representations = new HashSet<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                int start = arr[i];
                int end = start;

                while (i + 1 < arr.Length && arr[i + 1] == end + 1)
                {
                    end = arr[i + 1];
                    i++;
                }

                representations.Add($"{start}-{end}");
            }

            return representations.Count;
        }
    }
}
