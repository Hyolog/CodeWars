using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57ea70aa5500adfe8a000110/train/csharp"/>
    [TestClass]
    public class FoldAnArray
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 6, 6, 3 }, FoldArray(new int[] { 1, 2, 3, 4, 5 }, 1));
            CollectionAssert.AreEqual(new int[] { 15 }, FoldArray(new int[] { 1, 2, 3, 4, 5 }, 3));
            CollectionAssert.AreEqual(new int[] { 14, 75, 0 }, FoldArray(new int[] { -9, 9, -8, 8, 66, 23 }, 1));
        }

        public static int[] FoldArray(int[] array, int runs)
        {
            for (int i = 0; i < runs; i++)
                array = Fold(array);

            return array;
        }

        private static int[] Fold(int[] array)
        {
            int[] result;
            var length = array.Length;
            var mid = length / 2;

            if (length % 2 == 0)
            {
                result = new int[mid];

                for (int i = 0; i < mid; i++)
                    result[i] = array[i] + array[length - 1 - i];
            }
            else
            {
                result = new int[mid + 1];

                for (int i = 0; i < mid; i++)
                    result[i] = array[i] + array[length - 1 - i];

                result[mid] = array[mid];
            }

            return result;
        }
    }
}
