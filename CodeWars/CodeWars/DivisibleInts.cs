using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/566859a83557837d9700001a/train/csharp"/>
    [TestClass]
    public class DivisibleInts
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(2, GetCount(123));
            Assert.AreEqual(5, GetCount(1230));
            Assert.AreEqual(0, GetCount(1));
            Assert.AreEqual(25, GetCount(1111111111));
        }

        public static int GetCount(int N)
        {
            string number = N.ToString();
            int count = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i; j < number.Length; j++)
                {
                    int subInt = int.Parse(number.Substring(i, j - i + 1));

                    if (subInt != 0 && N % subInt == 0 && subInt != N)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
