using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5541f58a944b85ce6d00006a/train/csharp"/>
    [TestClass]
    public class ProductOfConsecutiveFibNumbers
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new ulong[] { 55, 89, 1 }, productFib(4895));
            CollectionAssert.AreEqual(new ulong[] { 21, 34, 1 }, productFib(714));
            CollectionAssert.AreEqual(new ulong[] { 34, 55, 0 }, productFib(800));
        }

        public ulong[] productFib(ulong prod)
        {
            ulong fibNum = 0;
            ulong fibNextNum = 1;
            ulong fibMultiply = 0;

            while (fibMultiply <= prod)
            {
                if (fibMultiply.Equals(prod))
                    return new ulong[] { fibNum, fibNextNum, 1 };
                else
                {
                    var tempNum = fibNextNum;
                    fibNextNum += fibNum;
                    fibNum = tempNum;
                }

                fibMultiply = fibNum * fibNextNum;
            }

            return new ulong[] { fibNum, fibNextNum, 0 };
        }
    }
}
