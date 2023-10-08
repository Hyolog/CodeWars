using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5f885fa9f130ea00207c7dc8/train/csharp"/>
    [TestClass]
    public class LoneliestCharacter
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new char[] { 'a' }, Loneliest("a"));
            CollectionAssert.AreEqual(new char[] { 'g' }, Loneliest("abc d   ef  g   h i j      "));
            CollectionAssert.AreEqual(new char[] { 'b' }, Loneliest("a   b   c"));
            CollectionAssert.AreEqual(new char[] { 'z' }, Loneliest("  abc  d  z    f gk s "));
            CollectionAssert.AreEqual(new char[] { 'b', 'c' }, Loneliest("a  b  c  de  ").OrderBy(x => x).ToArray());
            CollectionAssert.AreEqual(new char[] { 'a', 'b', 'c' }, Loneliest("abc").OrderBy(x => x).ToArray());
        }

        public static char[] Loneliest(string result)
        {
            int leftWhiteSpaceLength = 0;
            int rightWhiteSpaceLength = 0;
            char lastChar = '\0';
            var candidates = new Dictionary<char, int>();

            foreach (char c in result)
            {
                if (char.IsWhiteSpace(c))
                {
                    rightWhiteSpaceLength++;
                }
                else
                {
                    leftWhiteSpaceLength = rightWhiteSpaceLength;
                    rightWhiteSpaceLength = 0;

                    if (lastChar != '\0')
                    {
                        candidates[lastChar] += leftWhiteSpaceLength;
                    }

                    candidates.Add(c, leftWhiteSpaceLength);
                    lastChar = c;
                }
            }

            var max = candidates.Max(d => d.Value);

            return candidates.Where(d => d.Value == max).Select(d => d.Key).ToArray();
        }   
    }
}
