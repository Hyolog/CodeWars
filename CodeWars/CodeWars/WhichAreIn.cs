using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/550554fd08b86f84fe000a58/train/csharp"/>
    [TestClass]
    public class WhichAreIn
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new string[] { "arp", "live", "strong" }, 
                WhichAreIn.inArray(new string[] { "arp", "live", "strong" }, new string[] { "lively", "alive", "harp", "sharp", "armstrong" }));
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1.Where(d => array2.Any(i => i.Contains(d))).Distinct().OrderBy(d => d).ToArray();
        }
    }
}
