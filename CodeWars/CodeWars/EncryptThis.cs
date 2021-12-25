using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5848565e273af816fb000449/train/csharp"/>
    [TestClass]
    public class EncryptThis
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(EncryptThisFunc("Ab"), "65b");
            Assert.AreEqual(EncryptThisFunc(""), "");
            Assert.AreEqual(EncryptThisFunc("Abcd"), "65dcb");
            Assert.AreEqual(EncryptThisFunc("A wise old owl lived in an oak"), "65 119esi 111dl 111lw 108dvei 105n 97n 111ka");
        }

        public static string EncryptThisFunc(string input)
        {
            if (input.Length == 0)
                return "";

            var result = new List<string>();

            foreach (var item in input.Split(' '))
                result.Add(Encrypt(item));

            return string.Join(" ", result);
        }

        private static string Encrypt(string input)
        {
            var result = new StringBuilder();

            result.Append((int)input[0]);

            if (input.Length > 1)
                result.Append(input[input.Length - 1]);

            if (input.Length > 2)
            {
                result.Append(input.Substring(2, input.Length - 3));
                result.Append(input[1]);
            }

            return result.ToString();
        }
    }
}
