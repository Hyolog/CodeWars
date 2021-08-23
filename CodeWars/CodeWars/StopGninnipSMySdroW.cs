using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5264d2b162488dc400000001/solutions/csharp"/>
    [TestClass]
    public static class StopGninnipSMySdroW
    {
        [TestMethod]
        public static void Test()
        {
        }

        public static string SpinWords(string sentence)
        {
            return string.Join(' ', sentence.Split(' ').Select(d => d.Length >= 5 ? new string(d.Reverse().ToArray()) : d));
        }
    }
}