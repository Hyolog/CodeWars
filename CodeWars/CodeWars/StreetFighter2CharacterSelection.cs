using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5853213063adbd1b9b0000be/train/csharp"/>
    [TestClass]
    public class StreetFighter2CharacterSelection
    {
        private string[][] fighters = new string[][]
        {
            new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
            new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
        };

        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" },
                StreetFighterSelection(fighters, new int[] { 0, 0 }, new string[] { "up", "left", "right", "left", "left" }));

            CollectionAssert.AreEqual(new string[] { }, 
                StreetFighterSelection(fighters, new int[] { 0, 0 }, new string[] { }));
        }

        public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            var selectionHistory = new List<string>();

            foreach (var move in moves)
            {
                var nextPosition = Move(fighters, position, move);
                selectionHistory.Add(fighters[nextPosition[1]][nextPosition[0]]);
            }

            return selectionHistory.ToArray();
        }

        public int[] Move(string[][] fighters, int[] position, string move)
        {
            var xMax = fighters[0].Length - 1;
            var yMax = fighters.Length - 1;

            switch (move)
            {
                case "up": position[1]--; break;
                case "down": position[1]++; break;
                case "left": position[0]--; break;
                case "right": position[0]++; break;
                default: break;
            }

            if (position[0] < 0)
                position[0] = xMax;
            if (position[0] > xMax)
                position[0] = 0;
            if (position[1] < 0)
                position[1]++;
            if (position[1] > yMax)
                position[1]--;

            return position;
        }
    }
}
