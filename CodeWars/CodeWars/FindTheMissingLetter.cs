using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5839edaa6754d6fec10000a2/train/csharp"/>
    [TestClass]
    public class FindTheMissingLetter
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual('e',FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }

        public static char FindMissingLetter(char[] array)
        {
            var firstCharacter = array[0];
            var lastCharacter = array[array.Length - 1];
            var avg = (firstCharacter + lastCharacter) / 2.0;

            var expectedSum = avg * (array.Length + 1);
            var currentSum = 0.0;

            foreach (var item in array)
                currentSum += item;

            return (char)(expectedSum - currentSum);
        }
    }
}
