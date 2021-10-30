using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp"/>
    [TestClass]
    public class DetectPangram
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, IsPangram("The quick brown fox jumps over the lazy dog."));
        }

        public bool IsPangram(string str)
        {
            return str.ToLower().Where(d => char.IsLetter(d)).Distinct().Count() == 26;
        }
    }
}
