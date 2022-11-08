using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56cac350145912e68b0006f0/train/csharp"/>
    [TestClass]
    public class UpANDDown
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Arrange("who hit retaining The That a we taken"), "who RETAINING hit THAT a THE we TAKEN");
            Assert.AreEqual(Arrange("turn know great-aunts aunt look A to back"), "turn GREAT-AUNTS know AUNT a LOOK to BACK");
        }

        public static string Arrange(string strng)
        {
            var items = strng.Split(' ');

            for (int i = 0; i < items.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (items[i].Length > items[i + 1].Length)
                    {
                        Swap(ref items[i], ref items[i + 1]);
                    }
                }
                else
                {
                    if (items[i].Length < items[i + 1].Length)
                    {
                        Swap(ref items[i], ref items[i + 1]);
                    }
                }
            }

            return string.Join(' ', items.Select((item, i) => i % 2 == 0 ? item.ToLower() : item.ToUpper()));
        }

        private static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
