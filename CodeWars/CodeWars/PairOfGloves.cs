using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58235a167a8cb37e1a0000db/train/csharp"/>
    [TestClass]
    public class PairOfGloves
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, NumberOfPairs(new string[] { "Green", "Blue", "Purple", "Gray" }));
            Assert.AreEqual(0, NumberOfPairs(new string[] { }));
            Assert.AreEqual(0, NumberOfPairs(new string[] { "Purple" }));
            Assert.AreEqual(1, NumberOfPairs(new string[] { "Blue", "Purple", "Blue", "Gray", "Lime", "Black" }));
            Assert.AreEqual(1, NumberOfPairs(new string[] { "Blue", "Aqua", "Blue", "Teal", "Blue", "Black" }));
            Assert.AreEqual(2, NumberOfPairs(new string[] { "Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua" }));
        }

        public static int NumberOfPairs(string[] gloves)
        {
            var a = gloves.OrderBy(d => d).ToList();
            var result = 0;

            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    result++;
                    i++;
                }
            }

            return result;
        }    
    }
}
