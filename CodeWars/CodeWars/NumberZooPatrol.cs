using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5276c18121e20900c0000235/train/csharp"/>
    [TestClass]
    public class NumberZooPatrol
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, FindNumber(new int[] { 7, 8, 1, 2, 4, 5, 6 }));
            Assert.AreEqual(2, FindNumber(new int[] { 1, 3, 4, 5 }));

            Assert.AreEqual(12, FindNumber(new int[] { 13, 11, 10, 3, 2, 1, 4, 5, 6, 9, 7, 8 }));
            Assert.AreEqual(1, FindNumber(new int[] { }));
        }

        public static int FindNumber(int[] array)
        {
            var orderedArray = array.OrderBy(d => d).ToArray();
            
            if (orderedArray.Length == 0 || orderedArray[0] != 1)
                return 1;
            
            for (int i = 0; i < orderedArray.Length - 1; i++)
            {
                if (orderedArray[i] + 1 != orderedArray[i + 1])
                {
                    return orderedArray[i] + 1;
                }
            }

            return orderedArray[orderedArray.Length - 1] + 1;
        }
    }
}
