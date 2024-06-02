using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/56bdd0aec5dc03d7780010a5/train/csharp"/>
    [TestClass]
    public class FindNextHigherNumberWithSameBits
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(NextHigher(1), 2);
            Assert.AreEqual(NextHigher(128), 256);
            Assert.AreEqual(NextHigher(127), 191);
            Assert.AreEqual(NextHigher(201326592), 268435457);
        }

        public static int NextHigher(int n)
        {
            int c = n;
            int c0 = 0;
            int c1 = 0;

            while ((c & 1) == 0 && (c != 0))
            {
                c0++;
                c >>= 1;
            }

            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            if (c0 + c1 == 31 || c0 + c1 == 0)
            {
                return -1;
            }

            int p = c0 + c1;
            n |= (1 << p);

            n &= ~((1 << p) - 1);

            n |= (1 << (c1 - 1)) - 1;

            return n;
        }
    }
}
