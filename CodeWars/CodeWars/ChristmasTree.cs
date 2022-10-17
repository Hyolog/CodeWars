using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52755006cc238fcae70000ed/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class ChristmasTree
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("", ChristmasTreeFunc(0));
            Assert.AreEqual("*", ChristmasTreeFunc(1));
            Assert.AreEqual(" * \n***", ChristmasTreeFunc(2));
            Assert.AreEqual("  *  \n *** \n*****", ChristmasTreeFunc(3));
            Assert.AreEqual("   *   \n  ***  \n ***** \n*******", ChristmasTreeFunc(4));
            Assert.AreEqual("    *    \n   ***   \n  *****  \n ******* \n*********", ChristmasTreeFunc(5));
            Assert.AreEqual("       *       \n      ***      \n     *****     \n    *******    \n   *********   \n  ***********  \n ************* \n***************", ChristmasTreeFunc(8));
        }

        public static string ChristmasTreeFunc(int height)
        {
            if (height == 0)
                return "";

            var emptyLine = string.Empty.PadLeft(height * 2 - 1);
            var result = new List<string>();

            for (int i = 1; i <= height; i++)
            {
                var tempResult = emptyLine.ToCharArray();
                
                for (int j = height - i; j <= height + i - 2; j++)
                    tempResult[j] = '*';

                result.Add(new string(tempResult));
            }

            return string.Join("\n", result);
        }

        //string.Join("\n", Enumerable.Range(1, height).Select(i => new string('*', 2 * i - 1).PadLeft(height + i - 1).PadRight(2 * height - 1)));
    }
}