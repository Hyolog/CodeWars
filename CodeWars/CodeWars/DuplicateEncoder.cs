using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54b42f9314d9229fd6000d9c"/>
    [TestClass]
    public class DuplicateEncoder
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("(((", DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncode("Success"));
            Assert.AreEqual("))((", DuplicateEncode("(( @"));
        }

        public string DuplicateEncode(string word)
        {
            word = word.ToLower();

            return new string(word.Select(d => word.Count(c => c.Equals(d)) > 1 ? ')' : '(').ToArray());
        }
    }
}
