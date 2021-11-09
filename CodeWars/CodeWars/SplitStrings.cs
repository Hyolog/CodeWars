using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp"/>
    [TestClass]
    public class SplitStrings
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new string[] { "ab", "c_" }, Solution("abc"));
            CollectionAssert.AreEqual(new string[] { "ab", "cd", "ef" }, Solution("abcdef"));
        }

        public string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            var result = new string[str.Length / 2];

            for (int i = 0; i < result.Length; i++)
                result[i] = $"{str[i * 2]}{str[i * 2 + 1]}";

            return result;
        }
    }
}
