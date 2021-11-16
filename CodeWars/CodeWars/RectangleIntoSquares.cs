using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55466989aeecab5aac00003e/train/csharp"/>
    [TestClass]
    public class RectangleIntoSquares
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new List<int> { 3, 2, 1, 1 }, sqInRect(5, 3));
            CollectionAssert.AreEqual(null, sqInRect(5, 5));
        }

        public List<int> sqInRect(int lng, int wdth)
        {
            if (lng == wdth)
                return null;

            var result = new List<int>();

            while (true)
            {
                if (lng == wdth)
                {
                    result.Add(lng);
                    break;
                }
                else if (lng > wdth)
                {
                    lng -= wdth;
                    result.Add(wdth);
                }
                else
                {
                    wdth -= lng;
                    result.Add(lng);
                }
            }

            return result;
        }
    }
}
