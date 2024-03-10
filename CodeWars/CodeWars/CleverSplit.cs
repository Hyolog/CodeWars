using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5992e11d6ca73b38d50000f0/train/csharp"/>
    [TestClass]
    public class CleverSplit
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(CleverSplitFunc("Buy a !car [!red green !white] [cheap or !new]"), new string[] { "Buy", "a", "!car", "[!red green !white]", "[cheap or !new]" });
            CollectionAssert.AreEqual(CleverSplitFunc("!Learning !C# is [a joy]"), new string[] { "!Learning", "!C#", "is", "[a joy]" });
            CollectionAssert.AreEqual(CleverSplitFunc("[Cats and dogs] are !beautiful and [cute]"), new string[] { "[Cats and dogs]", "are", "!beautiful", "and", "[cute]" });
        }

        public static string[] CleverSplitFunc(string s)
        {
            var result = new List<string>();
            var stackCount = 0;
            var tempResult = new StringBuilder();

            foreach (var item in s)
            {

                if (item == ' ')
                {
                    if (stackCount == 0)
                    {
                        result.Add(tempResult.ToString());
                        tempResult.Clear();
                    }
                    else
                    {
                        tempResult.Append(item);
                    }
                }
                else if (item == '[')
                {
                    stackCount++;
                    tempResult.Append(item);
                }
                else if (item == ']')
                {
                    stackCount--;
                    tempResult.Append(item);
                }
                else
                {
                    tempResult.Append(item);
                }
            }

            if (tempResult != null)
                result.Add(tempResult.ToString());

            return result.ToArray();
        }
    }
}