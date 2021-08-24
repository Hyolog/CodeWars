using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/550f22f4d758534c1100025a/csharp"/>
    [TestClass]
    public class DirectionsReduction
    {
        [TestMethod]
        public void Test()
        {
        }



        public static string[] dirReduc(String[] arr)
        {
            var stack = new Stack<string>();

            foreach (var item in arr)
            {
                if (stack.Count > 0 && IsOpposite(stack.Peek(), item))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }

            return stack.ToArray();
        }

        public static bool IsOpposite(string sourceDirection, string targetDirection)
        {
            switch (sourceDirection)
            {
                case "EAST": return targetDirection == "WEST" ? true : false;
                case "WEST": return targetDirection == "EAST" ? true : false;
                case "SOUTH": return targetDirection == "NORTH" ? true : false;
                case "NORTH": return targetDirection == "SOUTH" ? true : false;
                default: return false;
            }
        }
    }
}