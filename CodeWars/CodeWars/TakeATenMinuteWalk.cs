using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54da539698b8a2ad76000228/csharp"/>
    [TestClass]
    public static class TakeATenMinuteWalk
    {
        [TestMethod]
        public static void Test()
        {
        }

        public static bool IsValidWalk(string[] walk)
        {
            return walk.Count() == 10 && IsReturned(walk);
        }

        public static bool IsReturned(string[] walk)
        {
            return walk.Count(d => d == "n") == walk.Count(d => d == "s") && walk.Count(d => d == "e") == walk.Count(d => d == "w") == true ? true : false;
        }
    }
}