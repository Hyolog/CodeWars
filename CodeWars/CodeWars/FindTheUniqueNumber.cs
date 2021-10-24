using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp"/>
    [TestClass]
    public class FindTheUniqueNumber
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(GetUnique(new int[] { 1, 2, 2, 2 }), 1);
            Assert.AreEqual(GetUnique(new int[] { -2, 2, 2, 2 }), -2);
            Assert.AreEqual(GetUnique(new int[] { 11, 11, 14, 11, 11 }), 14);
        }

        public int GetUnique(IEnumerable<int> numbers)
        {
            var nums = numbers.ToArray();

            var before = nums[0];

            if (before != nums[1])
            {
                if (before == nums[2])
                    return nums[1];
                else
                    return before;
            }

            for (int i = 2; i < nums.Length; i++)
            {
                if (before != nums[i])
                    return nums[i];
            }

            return 0;
        }
    }
}
