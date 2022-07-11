using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/596f72bbe7cd7296d1000029"/>
    [TestClass]
    public class ArrayDeepCount
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, DeepCount(new object[] { }));
            Assert.AreEqual(3, DeepCount(new object[] { 1, 2, 3 }));
            Assert.AreEqual(4, DeepCount(new object[] { "x", "y", new object[] { "z" } }));
            Assert.AreEqual(7, DeepCount(new object[] { 1, 2, new object[] { 3, 4, new object[] { 5 } } }));
            Assert.AreEqual(8, DeepCount(new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { } } } } } } } } }));
        }

        public static int DeepCount(object a)
        {
            return CountOfObject(a as object[]);
        }

        
        private static int CountOfObject(object[] objs)
        {
            var result = objs.Length;

            foreach (var obj in objs)
            {
                if (obj is object[])
                {
                    result += CountOfObject(obj as object[]);
                }
            }

            return result;
        }
    }
}
