using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5596f6e9529e9ab6fb000014/train/csharp"/>
    [TestClass]
    public class CalculateStringRotation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(4, CalculateStringRotation.ShiftedDiff("eecoff", "coffee"));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("Moose", "moose"));
            Assert.AreEqual(2, CalculateStringRotation.ShiftedDiff("isn't", "'tisn"));
            Assert.AreEqual(0, CalculateStringRotation.ShiftedDiff("Esham", "Esham"));
            Assert.AreEqual(0, CalculateStringRotation.ShiftedDiff(" ", " "));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("hoop", "pooh"));
            Assert.AreEqual(-1, CalculateStringRotation.ShiftedDiff("  ", " "));
        }

        public static int ShiftedDiff(string first, string second)
        {
            if (first.Length != second.Length)
                return -1;

            var secondDouble = second + second;

            for (int i = 0; i < first.Length; i++)
            {
                var subString = secondDouble.Substring(i, first.Length);

                if (subString == first)
                    return i;
            }

            return -1;
        }
    }
}
