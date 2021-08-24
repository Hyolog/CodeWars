using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/520b9d2ad5c005041100000f/csharp"/>
    [TestClass]
    public class SimplePigLatin
    {
        [TestMethod]
        public void Test()
        {
        }

        public static string PigIt(string str)
        {
            List<string> result = new List<string>();

            foreach (var item in str.Split(' '))
            {
                if (char.IsLetter(item[0]))
                {
                    result.Add(MoveFirstLetter(item) + "ay");
                }
                else
                {
                    result.Add(item);
                }
            }

            return string.Join(" ", result);
        }

        public static string MoveFirstLetter(string word)
        {
            return (word += word[0]).Remove(0, 1);
        }
    }
}