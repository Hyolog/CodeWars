using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5efae11e2d12df00331f91a6/train/csharp"/>
    [TestClass]
    public class CrackThePIN
    {
        [TestMethod]
        public void Test()
        {
            using (var md5 = MD5.Create())
            {
                byte[] tempHash = md5.ComputeHash(Encoding.ASCII.GetBytes("00078"));

                var result = BitConverter.ToString(tempHash).Replace("-", "").ToLowerInvariant();

                Assert.AreEqual("86aa400b65433b608a9db30070ec60cd", result);
            }

            Assert.AreEqual("00078", crack("86aa400b65433b608a9db30070ec60cd"));
            Assert.AreEqual("12345", crack("827ccb0eea8a706c4c34a16891f84e7b"));
        }

        public static string crack(string hash)
        {
            var input = 0;

            while (true)
            {
                using (var md5 = MD5.Create())
                {
                    var stringInput = GetDigitString(input);

                    byte[] hashByte = md5.ComputeHash(Encoding.ASCII.GetBytes(stringInput));
                    var tempHash = BitConverter.ToString(hashByte).Replace("-", "").ToLowerInvariant();

                    if (tempHash.Equals(hash))
                        return stringInput;

                    input += 1;
                } 
            }
        }

        private static string GetDigitString(int number)
        {
            if (number > 99999)
                throw new InvalidOperationException();
            else
            {
                return String.Format("{0:00000}", number);
            }
        }
    }
}
