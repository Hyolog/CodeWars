using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52b757663a95b11b3d00062d/train/csharp"/>
    /// TODO : Linq로 풀어보기
    [TestClass]
    public class WeIrDStRiNgCaSe
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("ThIs", ToWeirdCase("This"));
            Assert.AreEqual("Is", ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", ToWeirdCase("This is a test"));
        }

        public static string ToWeirdCase(string s)
        {
            var result = new StringBuilder();
            var isEven = true;

            foreach (var item in s)
            {
                if (item.Equals(' '))
                {
                    result.Append(' ');
                    isEven = true;
                }
                else
                {
                    if (isEven)
                    {
                        result.Append(char.ToUpper(item));
                        isEven = false;
                    }
                    else
                    {
                        result.Append(char.ToLower(item));
                        isEven = true;
                    }
                }
            }

            return result.ToString();
        }

    //    public static string ToWeirdCase(string s)
    //    {
    //        return string.Join(" ",
    //s.Split().Select(x =>
    //    string.Concat(x.Select((c, i) => i % 2 > 0 ? char.ToLower(c) : char.ToUpper(c)))));
    //    }
    }
}
