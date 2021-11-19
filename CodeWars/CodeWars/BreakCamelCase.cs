using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp"/>
    [TestClass]
    public class BreakCamelCase
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(BreakCamelCaseFunc("camelCasing"), "camel Casing");
            Assert.AreEqual(BreakCamelCaseFunc("camelCasingTest"), "camel Casing Test");
        }

        public static string BreakCamelCaseFunc(string str)
        {
            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    result.Append(" ");

                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}
