using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/598106cb34e205e074000031/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class TheDeafRatsOfHamelin
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(CountDeafRats("O~~OO~~OO~~OO~P~OO~~OO~~OO~~O"), 8);
            Assert.AreEqual(CountDeafRats("~O~O~O~O P"), 0);
            Assert.AreEqual(CountDeafRats("P O~ O~ ~O O~"), 1);
            Assert.AreEqual(CountDeafRats("~O~O~O~OP~O~OO~"), 2);
        }

        public static int CountDeafRats(string town)
        {
            var splited = town.Replace(" ", "").Split('P');

            var left = splited[0];
            var right = splited[1];
            var result = 0;

            for (int i = 0; i < left.Length; i += 2)
            {
                if (left[i] == 'O')
                    result++;
            }

            for (int i = 0; i < right.Length; i += 2)
            {
                if (right[i] == '~')
                    result++;
            }

            return result;
        }

        //public static int CountDeafRats(string town)
        //{
        //    return town.Replace(" ", "").Where((x, i) => i % 2 == 0).Count(x => x == 'O');
        //}
    }
}
