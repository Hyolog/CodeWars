using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59590976838112bfea0000fa/train/csharp"/>
    [TestClass]
    public class EnglishBeggars
    {
        [TestMethod]
        public void Test()
        {
            int[] test = { 1, 2, 3, 4, 5 };
            int[] a1 = { 15 }, a2 = { 9, 6 }, a3 = { 5, 7, 3 }, a4 = { 1, 2, 3, 4, 5, 0 }, a5 = { };
            CollectionAssert.AreEqual(a1, Beggars(test, 1));
            CollectionAssert.AreEqual(a2, Beggars(test, 2));
            CollectionAssert.AreEqual(a3, Beggars(test, 3));
            CollectionAssert.AreEqual(a4, Beggars(test, 6));
            CollectionAssert.AreEqual(a5, Beggars(test, 0));
        }

        public static int[] Beggars(int[] values, int n)
        {
            var beggars = new int[n];

            if (n == 0)
                return beggars;

            for (int i = 0; i < values.Length; i++)
                beggars[i % n] += values[i];

            return beggars;
        }
    }
}
