using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/552c028c030765286c00007d/solutions/csharp"/>
    [TestClass]
    public class IQTest
    {
        [TestMethod]
        public void Test()
        {
        }

        public static int GetIndexOfOddNum(IEnumerable<int> numbers)
        {
            return numbers.Select((num, index) => new { num, index }).First(d => d.num % 2 != 0).index + 1;
        }

        public static int GetIndexOfEvenNum(IEnumerable<int> numbers)
        {
            return numbers.Select((num, index) => new { num, index }).First(d => d.num % 2 == 0).index + 1;
        }
    }
}