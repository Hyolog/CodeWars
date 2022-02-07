using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5375f921003bf62192000746/train/csharp"/>
    /// TODO : 신경쓸게 많다? 다시 풀어보기
    [TestClass]
    public class WordA10n
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("i18n", Abbreviate("internationalization"));
            Assert.AreEqual("e6t-r3s are r4y fun!", Abbreviate("elephant-rides are really fun!"));
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.", Abbreviate("my. dog, isn't feeling very well."));

            Assert.AreEqual("You n2d, n2d not w2t, to c6e t2s c2e-w2s m5n", Abbreviate("You need, need not want, to complete this code-wars mission"));
            Assert.AreEqual("sat. d3y. b5n: d3y; sat", Abbreviate("sat. doggy. balloon: doggy; sat"));
        }

        public static string Abbreviate(string input)
        {
            char[] separators = input.Where(c => !char.IsLetter(c)).ToArray();
            var words = input.Split(separators);
            words = words.Select(d => d.Length < 4 ? d : d[0] + (d.Length - 2).ToString() + d[d.Length - 1]).ToArray();

            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < separators.Length; i++)
                result.Append(words[i] + separators[i]);

            result.Append(words[words.Length - 1]);

            return result.ToString();
        }
    }
}
