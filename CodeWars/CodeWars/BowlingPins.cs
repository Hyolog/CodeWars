using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/585cf93f6ad5e0d9bf000010/train/csharp"/>
    [TestClass]
    public class BowlingPins
    {
        [TestMethod]
        public void Test()
        {
            int[] testArray = new int[] { 1, 2, 3 };
            Assert.AreEqual("I I I I\n I I I \n       \n       ", BowlingPinsFunc(testArray));

            testArray = new int[] { 3, 5, 9 };
            Assert.AreEqual("I I   I\n I   I \n  I    \n   I   ", BowlingPinsFunc(testArray));
        }

        public string BowlingPinsFunc(int[] arr)
        {
            char[] field = Enumerable.Repeat('I', 10).ToArray();

            foreach (int pin in arr)
            {
                field[pin - 1] = ' ';
            }

            string result = $"{field[6]} {field[7]} {field[8]} {field[9]}\n";
            result += $" {field[3]} {field[4]} {field[5]} \n";
            result += $"  {field[1]} {field[2]}  \n";
            result += $"   {field[0]}   ";

            return result;
        }
    }
}
