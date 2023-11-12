using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5889902f53ad4a227100003f/train/csharp"/>
    [TestClass]
    public class SimpleFun54StringsCrossover
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(2, StringsCrossover(new string[] { "abc", "aaa", "aba", "bab" }, "bbb"));
            Assert.AreEqual(0, StringsCrossover(new string[] { "aacccc", "bbcccc" }, "abdddd"));
            Assert.AreEqual(4, StringsCrossover(new string[] { "a", "b", "c", "d", "e" }, "c"));
            Assert.AreEqual(1, StringsCrossover(new string[] { "aa", "ab", "ba" }, "bb"));
            Assert.AreEqual(0, StringsCrossover(new string[] { "a", "b", "c", "d", "e" }, "f"));
            Assert.AreEqual(1, StringsCrossover(new string[] { "aaa", "aaa" }, "aaa"));
        }

        public int StringsCrossover(string[] arr, string result)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (CanCrossover(arr[i], arr[j], result))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static bool CanCrossover(string A, string B, string result)
        {
            for (int k = 0; k < A.Length; k++)
            {
                if (result[k] != A[k] && result[k] != B[k])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
