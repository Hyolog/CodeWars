using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/587d7544f1be39c48c000109/train/csharp"/>
    [TestClass]
    public class SaveTheSpiceHarvester
    {
        [TestMethod]
        public void Test()
        {
            int[][] data = { new[] { 345, 600 }, new[] { 200, 100, 25 }, new[] { 350, 200, 32 } };
            Assert.AreEqual("The spice must flow! Rescue the harvester!", HarvesterRescue(data));
        }

        public static string HarvesterRescue(int[][] data)
        {
            var harvester = data[0];
            var worm = data[1];
            var carryall = data[2];

            var harvesterWormDistance = Math.Pow(Math.Pow(harvester[0] - worm[0], 2) + Math.Pow(harvester[1] - worm[1], 2), 0.5);
            var harvesterCarryallDistance = Math.Pow(Math.Pow(harvester[0] - carryall[0], 2) + Math.Pow(harvester[1] - carryall[1], 2), 0.5);

            double wormTime = harvesterWormDistance / worm[2];
            double carryallTime = harvesterCarryallDistance / carryall[2];

            return wormTime > carryallTime + 1 ? "The spice must flow! Rescue the harvester!" : "Damn the spice! I'll rescue the miners!";
        }
    }
}
