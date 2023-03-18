using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5410c0e6a0e736cf5b000e69/train/csharp"/>
    [TestClass]
    public class HammingDistance
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, Distance("I like turtles", "I like turkeys"));
        }

        public static int Distance(string a, string b)
        {
            var result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    result++;
            }

            return result;
        }
    }
}
