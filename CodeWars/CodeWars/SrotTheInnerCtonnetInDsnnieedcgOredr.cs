using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5898b4b71d298e51b600014b/train/csharp"/>
    [TestClass]
    public class SrotTheInnerCtonnetInDsnnieedcgOredr
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("srot the inner ctonnet in dsnnieedcg oredr", SortTheInnerContent("sort the inner content in descending order"));
            Assert.AreEqual("wiat for me", SortTheInnerContent("wait for me"));
            Assert.AreEqual("tihs ktaa is esay", SortTheInnerContent("this kata is easy"));
        }

        public static string SortTheInnerContent(string words)
        {
            var wordArray = words.Split(' ').ToArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                var word = wordArray[i];
                var sortedWord = word.Length < 3 ? 
                    word : word[0] + new string(word.Skip(1).Take(word.Length - 2).OrderByDescending(d => d).ToArray()) + word[word.Length - 1];
                wordArray[i] = sortedWord;
            }

            return string.Join(' ', wordArray);
        }
    }
}
