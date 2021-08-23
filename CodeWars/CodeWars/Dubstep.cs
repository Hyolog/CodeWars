using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/551dc350bf4e526099000ae5/solutions/csharp"/>
    [TestClass]
    public static class Dubstep
    {
        [TestMethod]
        public static void Test()
        {
        }

        public static string SongDecoder(string input)
        {
            var replacedInput = input.Replace("WUB", " ");
            StringBuilder result = new StringBuilder();

            bool isContinuous = false;

            for (int i = 0; i < replacedInput.Length; i++)
            {
                if (Char.IsWhiteSpace(replacedInput[i]))
                {
                    if (!isContinuous)
                    {
                        result.Append(replacedInput[i]);
                        isContinuous = true;
                    }
                }
                else
                {
                    result.Append(replacedInput[i]);
                    isContinuous = false;
                }
            }

            if (Char.IsWhiteSpace(result[0]))
            {
                result.Remove(0, 1);
            }

            if (Char.IsWhiteSpace(result[result.Length - 1]))
            {
                result.Remove(result.Length - 1, 1);
            }

            return result.ToString();
        }
    }
}