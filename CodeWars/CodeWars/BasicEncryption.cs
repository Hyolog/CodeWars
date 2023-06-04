using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5862fb364f7ab46270000078/train/csharp"/>
    [TestClass]
    public class BasicEncryption
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Encrypt("", 1), "");
            Assert.AreEqual(Encrypt("a", 1), "b");
            Assert.AreEqual(Encrypt("please encrypt me", 2), "rngcug\"gpet{rv\"og");
        }

        public static string Encrypt(string text, int rule)
        {
            string encryptedText = "";

            foreach (char c in text)
            {
                int asciiValue = (int)c;
                int encryptedAsciiValue = (asciiValue + rule) % 256;
                encryptedText += (char)encryptedAsciiValue;
            }
            return encryptedText;
        }
    }
}
