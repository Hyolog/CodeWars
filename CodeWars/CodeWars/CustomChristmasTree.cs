using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a405ba4e1ce0e1d7800012e/train/csharp"/>
    [TestClass]
    public class CustomChristmasTree
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("  *\n" +
                      " @ o\n" +
                      "* @ o\n" +
                      "  |", CustomChristmasTreeFunc("*@o", 3));

            Assert.AreEqual("     *\n" +
                            "    @ o\n" +
                            "   * @ o\n" +
                            "  * @ o *\n" +
                            " @ o * @ o\n" +
                            "* @ o * @ o\n" +
                            "     |\n" +
                            "     |", CustomChristmasTreeFunc("*@o", 6));

            Assert.AreEqual("     1\n" +
                            "    2 3\n" +
                            "   4 1 2\n" +
                            "  3 4 1 2\n" +
                            " 3 4 1 2 3\n" +
                            "4 1 2 3 4 1\n" +
                            "     |\n" +
                            "     |", CustomChristmasTreeFunc("1234", 6));

            Assert.AreEqual("  1\n" +
                            " 2 3\n" +
                            "4 5 6\n" +
                            "  |", CustomChristmasTreeFunc("123456789", 3));
        }

        public string CustomChristmasTreeFunc(string chars, int n)
        {
            var result = new StringBuilder();
            var index = 0;
            var maxIndex = chars.Length - 1;

            // Set leaves
            for (int i = 1; i <= n; i++)
            {
                var row = new StringBuilder();
                var count = i;
                var emptySpace = n - i;

                // Set empty space
                for (int j = 1; j <= emptySpace; j++)
                {
                    row.Append(' ');
                }

                // Set leaves
                for (int k = 1; k <= count; k++)
                {
                    row.Append(chars[index]);
                    row.Append(' ');
                    index++;

                    if (index > maxIndex)
                    {
                        index = 0;
                    }
                }

                var length = row.Length;
                row[length - 1] = '\n';

                result.Append(row);
            }

            var trunkCount = n / 3;
            var empty = n - 1;
            // Set trunks
            for (int l = 0; l < trunkCount; l++)
            {
                var row = new StringBuilder();

                for (int m = 0; m < empty; m++)
                {
                    row.Append(' ');
                }

                row.Append('|');
                row.Append('\n');

                result.Append(row);
            }

            var leng = result.Length;
            result.Remove(leng - 1, 1);

            return result.ToString();
        }
    }
}
