using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/6040b781e50db7000ab35125/train/csharp"/>
    /// Todo : 다시 풀어보기
    [TestClass]
    public class DeltaGenerators
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(new[] { 1, 1, 1, 1, 1 }.SequenceEqual(Delta(new[] { 1, 2, 3, 4, 5, 6 }, 1)));
        }

        public static IEnumerable<int> Delta(IEnumerable<int> enumerable, int n)
        {
            if (enumerable.Count() < 1)
                throw new Exception();

            for (int i = 1; i < enumerable.Count(); i++)
            {
                yield return enumerable.ElementAt(i) - enumerable.ElementAt(i - 1);
            }
        }
    }
}
