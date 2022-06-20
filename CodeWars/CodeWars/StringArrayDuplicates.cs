using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59f08f89a5e129c543000069/train/csharp"/>
    [TestClass]
    public class StringArrayDuplicates
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new string[] { "codewars", "picaniny", "hubububo" }, dup(new string[] { "ccooddddddewwwaaaaarrrrsssss", "piccaninny", "hubbubbubboo" }));
            CollectionAssert.AreEqual(new string[] { "abracadabra", "alote", "asese" }, dup(new string[] { "abracadabra", "allottee", "assessee" }));
            CollectionAssert.AreEqual(new string[] { "keles", "kenes" }, dup(new string[] { "kelless", "keenness" }));
        }

        public static string[] dup(string[] arr)
        {
            var result = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                char pivot = char.MinValue;
                var after = new List<char>();

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] != pivot)
                    {
                        after.Add(arr[i][j]);
                        pivot = arr[i][j];
                    }
                }

                result[i] = new string(after.ToArray());
            }

            return result;
        }
    }
}
