using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55c9172ee4bb15af9000005d/train/csharp"/>
    [TestClass]
    public class Pentabonacci
    {
        [TestMethod]
        public void Test()
        {
            long[] lstI = new long[] { 45, 68, 76, 100, 121 };
            long[] resultsI = new long[] { 15, 23, 25, 33, 40 };
            for (int i = 0; i <= 4; i++)
            {
                Assert.AreEqual(CountOddPentaFib(lstI[i]), resultsI[i]);
            }
        }

        private static List<long> sequence = new List<long> { 0, 1, 1, 2, 4 };

        public static long CountOddPentaFib(long n)
        {
            while (sequence.Count <= n)
            {
                long nextValue = sequence[sequence.Count - 1] + sequence[sequence.Count - 2] + sequence[sequence.Count - 3]
                                 + sequence[sequence.Count - 4] + sequence[sequence.Count - 5];
                sequence.Add(nextValue);
            }

            HashSet<long> oddTerms = new HashSet<long>();
            for (long i = 0; i <= n; i++)
            {
                if (sequence[(int)i] % 2 != 0)
                {
                    oddTerms.Add(sequence[(int)i]);
                }
            }

            return oddTerms.Count;
        }
    }
}
