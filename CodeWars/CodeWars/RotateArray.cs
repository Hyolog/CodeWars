using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54f8b0c7a58bce9db6000dc4/train/csharp"/>
    [TestClass]
    public class RotateArray
    {
        [TestMethod]
        public void Test()
        {
            var data = new object[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, Rotate(data, 1));
            CollectionAssert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, Rotate(data, 2));
            CollectionAssert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, Rotate(data, 3));
            CollectionAssert.AreEqual(new object[] { 2, 3, 4, 5, 1 }, Rotate(data, 4));
            CollectionAssert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, Rotate(data, 5));

            CollectionAssert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, Rotate(data, 0));

            CollectionAssert.AreEqual(new object[] { 2, 3, 4, 5, 1 }, Rotate(data, -1));
            CollectionAssert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, Rotate(data, -2));
            CollectionAssert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, Rotate(data, -3));
            CollectionAssert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, Rotate(data, -4));
            CollectionAssert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, Rotate(data, -5));

            CollectionAssert.AreEqual(new object[] { 'c', 'a', 'b' }, Rotate(new object[] { 'a', 'b', 'c' }, 1));
            CollectionAssert.AreEqual(new object[] { 3.0, 1.0, 2.0 }, Rotate(new object[] { 1.0, 2.0, 3.0 }, 1));
            CollectionAssert.AreEqual(new object[] { false, true, true }, Rotate(new object[] { true, true, false }, 1));

            CollectionAssert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, Rotate(data, 7));
            CollectionAssert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, Rotate(data, 11));
            CollectionAssert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, Rotate(data, 12478));
        }

        public static object[] Rotate(object[] array, int n)
        {
            if (array == null || array.Length == 0)
                return array;

            int len = array.Length;
            n %= len;

            if (n < 0)
                n += len;

            return array.Skip(len - n).Concat(array.Take(len - n)).ToArray();
        }
    }
}
