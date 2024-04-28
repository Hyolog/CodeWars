using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5aa3e2b0373c2e4b420009af/train/csharp"/>
    [TestClass]
    public class SquareStringTops
    {
        [TestMethod]
        public void Test()
        {
            string parameter;
            string message = "With msg = \"{0}\"";

            parameter = "";
            Assert.AreEqual("", Tops(parameter), message, parameter);

            parameter = "abcde";
            Assert.AreEqual("cd", Tops(parameter), message, parameter);

            parameter = "123456789abcdefghijklmnopqrstuwyxvzABCDEFGHIJKLMNOPQRSTU";
            Assert.AreEqual("TUABCDElmnoabc34", Tops(parameter), message, parameter);

            parameter = "123456789abcdefghijklmnopqrstuwyxvzABCDEFGHIJKLMNOPQRSTUWvXYZ123456789012345678910123";
            Assert.AreEqual("7891012TUWvXYABCDElmnoabc34", Tops(parameter), message, parameter);
        }

        public static string Tops(string msg)
        {
            var length = msg.Length;
            var count = 2;
            var startValue = GetStartValue(count - 1);
            var tempResult = new List<string>();

            while (startValue <= length)
            {
                if (startValue + count <= length)
                    tempResult.Add(msg.Substring(startValue, count));
                else
                {
                    count = length - startValue;
                    tempResult.Add(msg.Substring(startValue, count));
                    break;
                }

                count++;
                startValue = GetStartValue(count - 1);
            }

            var result = new StringBuilder();

            for (int i = tempResult.Count - 1; i >= 0; i--)
            {
                result.Append(tempResult[i]);
            }

            return result.ToString();
        }

        private static int GetStartValue(int index)
        {
            return index * (2 * index + 1) - 1;
        }
    }
}
