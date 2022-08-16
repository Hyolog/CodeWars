using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class FirstNonRepeatingCharacter
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("", FirstNonRepeatingLetter("aa"));
            Assert.AreEqual("a", FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual(",", FirstNonRepeatingLetter("Go hang a salami, I'm a lasagna hog!"));
            Assert.AreEqual("T", FirstNonRepeatingLetter("sTreSS"));
            Assert.AreEqual("e", FirstNonRepeatingLetter("f\u0080MDYqnGB`c"));
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var dic = new Dictionary<char, bool>();

            foreach (var item in s)
            {
                var low = char.ToLower(item);
                var up = char.ToUpper(item);

                if (dic.TryGetValue(low, out var isRepet))
                {
                    dic[low] = true;
                }
                else if (dic.TryGetValue(up, out var isRepet2))
                {
                    dic[up] = true;
                }
                else
                {
                    dic.Add(item, false);
                }
            }

            var result = dic.FirstOrDefault(d => d.Value == false).Key.ToString();
            
            return result.Equals("\0") ? "" : result;
        }
    }
}
