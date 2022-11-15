using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/557e8a141ca1f4caa70000a6/train/csharp"/>
    [TestClass]
    public class TriangleNumberCheck
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, isTriangleNumber(125250));
        }

        public static bool isTriangleNumber(long number)
        {
            var triangleNum = 1;
            var index = 1;

            while (triangleNum < number)
            {
                triangleNum = index * (index + 1) / 2;

                if (triangleNum == number)
                    return true;
                else
                    index++;
            }

            return false;
        }
    }
}
