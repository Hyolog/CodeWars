using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/522551eee9abb932420004a0/train/csharp"/>
    [TestClass]
    public class DefaulNFibonacciTemplate
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, NthFib(1));
            Assert.AreEqual(1, NthFib(2));
            Assert.AreEqual(1, NthFib(3));
            Assert.AreEqual(2, NthFib(4));
            Assert.AreEqual(8, NthFib(7));
        }

        //public int NthFib(int n)
        //{
        //    if (n == 1)
        //        return 0;
        //    else if (n == 2)
        //        return 1;
        //    else
        //        return (NthFib(n - 1) + NthFib(n - 2));
        //}

        public int NthFib(int n)
        {
            var temp = new int[n + 2];
            temp[1] = 0;
            temp[2] = 1;

            for (int i = 3; i <= n; i++)
                temp[i] = temp[i - 1] + temp[i - 2];

            return temp[n];
        }
    }
}
