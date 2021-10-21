using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5842df8ccbd22792a4000245/train/csharp"/>
    [TestClass]
    public class WriteNumberInExpandedForm
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(ExpandedForm(12), "10 + 2");
            Assert.AreEqual(ExpandedForm(42), "40 + 2");
            Assert.AreEqual(ExpandedForm(70304), "70000 + 300 + 4");
        }

        public string ExpandedForm(long num)
        {
            var result = new List<string>();
            var numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                if (numString[i] != '0')
                {
                    var tempResult = "";
                    tempResult += numString[i];

                    for (int j = 0; j < numString.Length - i - 1; j++)
                        tempResult += "0";

                    result.Add(tempResult);
                }
            }

            return string.Join(" + ", result);
        }
    }
}
