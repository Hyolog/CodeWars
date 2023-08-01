using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/525f47c79f2f25a4db000025/train/csharp"/>
    [TestClass]
    public class ValidPhoneNumber
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(ValidPhoneNumberFunc("(123) 456-7890"));
            Assert.IsFalse(ValidPhoneNumberFunc("(1111)5X5 2345"));
        }

        public static bool ValidPhoneNumberFunc(string phoneNumber)
        {
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
