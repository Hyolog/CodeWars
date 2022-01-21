using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/train/csharp"/>
    [TestClass]
    public class BackspacesInString
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("ac", CleanString("abc#d##c"));
            Assert.AreEqual("", CleanString("abc####d##c#"));
            Assert.AreEqual("", CleanString("22#####"));
            Assert.AreEqual("9z^SRD9s", CleanString("#aI####n#4#v#P#L#9c#z4i#OF##KfFb#R###V###^SRW#g#D)#F#1#9sAm##iH)#2#9###"));
        }

        public static string CleanString(string s)
        {
            var result = new Stack<char>();

            foreach (var item in s)
            {
                if (item.Equals('#'))
                {
                    if (result.Count > 0)
                        result.Pop();
                }
                else
                    result.Push(item);
            }

            if (result.Count > 0 && result.Peek().Equals('#'))
                result.Pop();

            return new string(result.Reverse().ToArray());
        }
    }
}
