using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5f7c38eb54307c002a2b8cc8/train/csharp"/>
    [TestClass]
    public class RemoveTheParentheses
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("exampleexample", RemoveParentheses("example(unwanted thing)example"));
            Assert.AreEqual("example  example", RemoveParentheses("example (unwanted thing) example"));
            Assert.AreEqual("a e", RemoveParentheses("a (bc d)e"));
            Assert.AreEqual("a", RemoveParentheses("a(b(c))"));
            Assert.AreEqual("hello example  something", RemoveParentheses("hello example (words(more words) here) something"));
            Assert.AreEqual("  ", RemoveParentheses("(first group) (second group) (third group)"));
        }

        public static string RemoveParentheses(string s)
        {
            while (true)
            {
                int openIndex = s.LastIndexOf('(');
                if (openIndex == -1)
                    break;

                int closeIndex = s.IndexOf(')', openIndex);
                if (closeIndex == -1)
                    break;

                s = s.Remove(openIndex, closeIndex - openIndex + 1);
            }

            return s;
        }
    }
}
