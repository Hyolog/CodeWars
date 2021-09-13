using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp"/>
    [TestClass]
    public class CreatePhoneNumber
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(CreatePhoneNumberFunc(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }), "(123) 456-7890");
            Assert.AreEqual(CreatePhoneNumberFunc(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }), "(111) 111-1111");
        }

        public string CreatePhoneNumberFunc(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
    }
}
