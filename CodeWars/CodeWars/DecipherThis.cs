using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/581e014b55f2c52bb00000f8/train/csharp"/>
    [TestClass]
    public class DecipherThis
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(DecipherThisFunc(""), "");
            Assert.AreEqual(DecipherThisFunc("72olle 103doo 100ya"), "Hello good day");
            Assert.AreEqual(DecipherThisFunc("82yade 115te 103o"), "Ready set go");
            Assert.AreEqual(DecipherThisFunc("65 119esi 111dl 111lw 108dvei 105n 97n 111ka"), "A wise old owl lived in an oak");
        }

        public static string DecipherThisFunc(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "";

            var result = new StringBuilder();

            foreach (var word in s.Split(' '))
            {
                result.Append(Decipher(word));
                result.Append(" ");
            }

            return result.ToString().Trim();
        }

        private static string Decipher(string s)
        {
            int indexOfFirstChar = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    indexOfFirstChar = i;
                    break;
                }
            }

            var number = indexOfFirstChar == 0 ? s : s.Substring(0, indexOfFirstChar);
            s = s.Replace(number, $"{(char)int.Parse(number)}");

            if (s.Length >= 3)
            {
                var tempResult = s.ToCharArray();

                var secondChar = tempResult[1];
                var lastChar = tempResult[tempResult.Length - 1];

                tempResult[1] = lastChar;
                tempResult[tempResult.Length - 1] = secondChar;

                return new string(tempResult);
            }

            return s;
        }
    }
}