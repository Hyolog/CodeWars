using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5b1956a7803388baae00003a/train/csharp"/>
    [TestClass]
    public class CamelCaseUoUnderscore
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("This_Is_A_Unit_Test", ToUnderScore("ThisIsAUnitTest"));
            Assert.AreEqual("This_Should_Be_Split_Correct_Into_Underscore", ToUnderScore("ThisShouldBeSplitCorrectIntoUnderscore"));
        }

        public static string ToUnderScore(string name)
        {
            var result = new StringBuilder();
            bool isFirst = true;


            foreach (var item in name)
            {
                if (char.IsUpper(item))
                {
                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        result.Append('_');
                    }
                }

                result.Append(item);
            }

            return result.ToString();
        }
    }
}
