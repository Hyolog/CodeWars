using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/546f922b54af40e1e90001da/solutions/csharp"/>
    [TestClass]
    public static class ReplaceWithAlphabetPosition
    {
        [TestMethod]
        public static void Test()
        {
        }

        public static string AlphabetPosition(string text)
        {
            var charArray = text.ToUpper().Replace(" ", "").ToCharArray();

            string result = "";

            // A = 65 in ascii
            foreach (var item in charArray)
            {
                if (IsCapitalAlphabet(item))
                {
                    result += $"{item - 64} ";
                }
            }

            return result.Length == 0 ? "" : result.Remove(result.Length - 1, 1);
        }

        public static bool IsCapitalAlphabet(char character)
        {
            return (character > 64 && character < 91);
        }
    }
}