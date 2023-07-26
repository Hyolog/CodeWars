using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref=""/>
    [TestClass]
    public class SimpleFun165Withdraw
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 2 }, Withdraw(40));
            CollectionAssert.AreEqual(new int[] { 2, 1, 0 }, Withdraw(250));
            CollectionAssert.AreEqual(new int[] { 2, 0, 3 }, Withdraw(260));
            CollectionAssert.AreEqual(new int[] { 1, 1, 4 }, Withdraw(230));
            CollectionAssert.AreEqual(new int[] { 0, 0, 3 }, Withdraw(60));
        }

        public int[] Withdraw(int n)
        {
            int[] bills = new int[3];

            bills[0] = n / 100;
            n %= 100;

            if (n >= 50 && n % 20 != 0)
            {
                bills[1] = 1;
                n -= 50;
            }
            else if (n < 50 && n % 20 != 0)
            {
                bills[0] -= 1;
                n += 100;

                bills[1] = 1;
                n -= 50;
            }

            bills[2] = n / 20;

            return bills;
        }
    }
}
