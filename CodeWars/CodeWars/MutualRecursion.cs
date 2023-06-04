using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/53a1eac7e0afd3ad3300008b/train/csharp"/>
    [TestClass]
    public class MutualRecursion
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, F(0));
            Assert.AreEqual(0, M(0));

            Assert.AreEqual(1, F(1));
            Assert.AreEqual(0, M(1));

            Assert.AreEqual(2, F(2));
            Assert.AreEqual(1, M(2));
        }

        public static List<int> f = new List<int>();
        public static List<int> m = new List<int>();

        public static int F(int n)
        {
            if (n == 0) 
                return 1;
            if (n < f.Count)
                return f[n];
            
            f.Add(n - M(F(n - 1)));
            
            return n - M(F(n - 1));
        }
        public static int M(int n)
        {
            if (n == 0) 
                return 0;
            if (n < m.Count)
                return m[n];
            
            m.Add(n - F(M(n - 1)));
            
            return n - F(M(n - 1));
        }
    }
}
