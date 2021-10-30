using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp"/>
    [TestClass]
    public class MexicanWave
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" }, wave("hello"));
            CollectionAssert.AreEqual(new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" }, wave("two words"));
            CollectionAssert.AreEqual(new List<string> { " Gap ", " gAp ", " gaP " }, wave(" gap "));
        }

        public List<string> wave(string str)
        {
            var result = new List<string>();
            var lowerString = str.ToLower().ToCharArray();
            var pivot = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(lowerString[pivot]))
                {
                    lowerString[pivot] = char.ToUpper(lowerString[pivot]);
                    result.Add(new string(lowerString));
                    lowerString[pivot] = char.ToLower(lowerString[pivot]);
                }

                pivot++;
            }

            return result;
        }

        // 참고용 좋은 풀이
        //public List<string> wave(string str)
        //{ 
        //    return str
        //    .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
        //    .Where(x => x != str)
        //    .ToList();
        //}
    }
}
