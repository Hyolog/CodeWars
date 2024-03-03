using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58b8dccecf49e57a5a00000e/train/csharp"/>
    [TestClass]
    public class SimpleFun180RepeatAdjacent
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(1, RepeatAdjacent("aabbcdde"));
            Assert.AreEqual(3, RepeatAdjacent("ccccoodeffffiiighhhhhhhhhhttttttts"));
            Assert.AreEqual(0, RepeatAdjacent("soooooldieeeeeer"));
            Assert.AreEqual(1, RepeatAdjacent("ccccoooooooooooooooooooooooddee"));
            Assert.AreEqual(1, RepeatAdjacent("chaaallengee"));
            Assert.AreEqual(2, RepeatAdjacent("wwwwaaaarrioooorrrrr"));
            Assert.AreEqual(2, RepeatAdjacent("gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp"));
        }

        public int RepeatAdjacent(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var builder = new StringBuilder();
            char lastLastChar = '-';
            char lastChar = '.';
            bool IsGroup = false;
            bool IsBigGroup = false;
            var countOfBigGroup = 0;

            foreach (var item in s)
            {
                if (lastChar != item)
                {
                    if (lastLastChar == lastChar)
                    {
                        if (IsGroup)
                            IsBigGroup = true;

                        IsGroup = true;
                    }
                    else
                    {
                        if (IsBigGroup)
                            countOfBigGroup++;

                        IsGroup = false;
                        IsBigGroup = false;
                    }
                }

                lastLastChar = lastChar;
                lastChar = item;
            }

            if (IsBigGroup)
                countOfBigGroup++;
            else if (IsGroup)
                if (lastLastChar == lastChar)
                    countOfBigGroup++;

            return countOfBigGroup;
        }
    }
}
