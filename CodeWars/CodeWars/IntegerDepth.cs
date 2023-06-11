using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59b401e24f98a813f9000026/train/csharp"/>
    [TestClass]
    public class IntegerDepth
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(10, ComputeDepth(1));
            Assert.AreEqual(9, ComputeDepth(42));
        }

        public static int ComputeDepth(int n)
        {
            HashSet<int> digits = new HashSet<int>();
            int depth = 0;

            while (digits.Count < 10)
            {
                depth++;
                int multiple = n * depth;

                while (multiple > 0)
                {
                    digits.Add(multiple % 10);
                    multiple /= 10;
                }
            }

            return depth;
        }
    }
}
