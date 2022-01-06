using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57814d79a56c88e3e0000786/train/csharp"/>
    /// TODO : linq로 다시 풀어보기
    [TestClass]
    public class SimpleEncryption1AlternatingSplit
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("", Encrypt("", 0));
            Assert.AreEqual("", Decrypt("", 0));

            Assert.AreEqual(null, Encrypt(null, 0));
            Assert.AreEqual(null, Decrypt(null, 0));

            Assert.AreEqual("This is a test!", Encrypt("This is a test!", 0));
            Assert.AreEqual("hsi  etTi sats!", Encrypt("This is a test!", 1));
            Assert.AreEqual("s eT ashi tist!", Encrypt("This is a test!", 2));
            Assert.AreEqual(" Tah itse sits!", Encrypt("This is a test!", 3));
            Assert.AreEqual("This is a test!", Encrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", Encrypt("This is a test!", -1));
            Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", Encrypt("This kata is very interesting!", 1));

            Assert.AreEqual("This is a test!", Decrypt("This is a test!", 0));
            Assert.AreEqual("This is a test!", Decrypt("hsi  etTi sats!", 1));
            Assert.AreEqual("This is a test!", Decrypt("s eT ashi tist!", 2));
            Assert.AreEqual("This is a test!", Decrypt(" Tah itse sits!", 3));
            Assert.AreEqual("This is a test!", Decrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", Decrypt("This is a test!", -1));
            Assert.AreEqual("This kata is very interesting!", Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }

        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            while (n > 0)
            {
                var oddText = new List<char>();
                var evenText = new List<char>();

                for (int i = 0; i < text.Length; i++)
                {
                    if (i % 2 == 0)
                        evenText.Add(text[i]);
                    else
                        oddText.Add(text[i]);
                }

                text = new string(oddText.ToArray()) + new string(evenText.ToArray());

                n--;
            }

            return text;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrWhiteSpace(encryptedText))
                return encryptedText;

            var tempText = new char[encryptedText.Length];

            while (n > 0)
            {
                var oddIndex = 0;
                var evenIndex = encryptedText.Length / 2;

                for (int i = 0; i < tempText.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        tempText[i] = encryptedText[evenIndex];
                        evenIndex++;
                    }
                    else
                    {
                        tempText[i] = encryptedText[oddIndex];
                        oddIndex++;
                    }
                }

                encryptedText = new string(tempText);

                n--;
            }

            return encryptedText;
        }
    }
}
