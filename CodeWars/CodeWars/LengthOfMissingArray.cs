using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57b6f5aadb5b3d0ae3000611/train/csharp"/>
    [TestClass]
    public class LengthOfMissingArray
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } }));
            Assert.AreEqual(5, GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' } }));
            Assert.AreEqual(0, GetLengthOfMissingArray(new object[][] { new object[] { }, new object[] { 1 } }));
        }

    public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null || arrayOfArrays.Length == 0)
                return 0;

            var lengths = new List<int>();

            foreach (var array in arrayOfArrays)
            {
                if (array == null || array.Length == 0)
                    return 0;

                lengths.Add(array.Length);
            }

            var lengthArray = lengths.OrderBy(d => d).ToArray();

            for (int i = 1; i < lengthArray.Count(); i++)
            {
                if (lengthArray[i - 1] + 1 != lengthArray[i])
                {
                    return lengthArray[i - 1] + 1;
                }
            }

            return 0;
        }
    }
}
