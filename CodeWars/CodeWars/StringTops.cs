using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59b7571bbf10a48c75000070/train/csharp"/>
    [TestClass]
    public class StringTops
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(String.Empty, Tops(String.Empty));
            Assert.AreEqual("2", Tops("12"));
            Assert.AreEqual("3pgb", Tops("abcdefghijklmnopqrstuvwxyz12345"));
            Assert.AreEqual("M3pgb", Tops("abcdefghijklmnopqrstuvwxyz1236789ABCDEFGHIJKLMN"));
        }

        public static string Tops(string msg)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 1, j = 2; i < msg.Length; i += j * 2 + 1, j += 2)
            {
                str.Append(msg[i]);
            }

            char[] chars = str.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
