using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/csharp"/>
    [TestClass]
    public class BuildTower
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", TowerBuilder(3)));
        }

        public string[] TowerBuilder(int nFloors)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < nFloors; i++)
            {
                StringBuilder tempResult = new StringBuilder();
                var halfLength = nFloors - 1;

                for (int j = 0; j < halfLength - i; j++)
                    tempResult.Append(" ");
                
                for (int j = halfLength - i; j < halfLength; j++)
                    tempResult.Append("*");

                tempResult.Append("*");

                for (int j = 0; j < i; j++)
                    tempResult.Append("*");

                for (int j = i; j < halfLength; j++)
                    tempResult.Append(" ");

                result.Add(tempResult.ToString());
            }

            return result.ToArray();
        }
    }
}
