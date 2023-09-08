using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59901fb5917839fe41000029/train/csharp"/>
    [TestClass]
    public class GenericNumericTemplateFormatter
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("123 45678 90", NumericFormatter("xxx xxxxx xx"));
            Assert.AreEqual("+555 1234 5678", NumericFormatter("+555 aaaa bbbb"));
            Assert.AreEqual("1234 5678 9012", NumericFormatter("xxxx yyyy zzzz"));
        }

        public static string NumericFormatter(string template, string number = "1234567890")
        {
            int numberIndex = 0;

            char[] result = new char[template.Length];

            for (int i = 0; i < template.Length; i++)
            {
                char currentChar = template[i];
                if (char.IsLetter(currentChar))
                {
                    result[i] = number[numberIndex];
                    numberIndex = (numberIndex + 1) % number.Length;
                }
                else
                {
                    result[i] = currentChar;
                }
            }

            return new string(result);
        }
    }
}
