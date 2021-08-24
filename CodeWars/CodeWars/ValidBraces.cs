using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5277c8a221e209d3f6000b56/csharp"/>
    [TestClass]
    public class ValidBraces
    {
        [TestMethod]
        public void Test()
        {
        }

        public static bool validBraces(String braces)
        {
            var stack = new Stack<char>();

            foreach (var brace in braces.ToList())
            {
                if (stack.Count == 0)
                {
                    stack.Push(brace);
                }
                else if (IsOppositeBrace(stack.First(), brace))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(brace);
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOppositeBrace(char source, char target)
        {
            if (source == '(' && target == ')')
            {
                return true;
            }
            else if (source == '[' && target == ']')
            {
                return true;
            }
            else if (source == '{' && target == '}')
            {
                return true;
            }

            return false;
        }
    }
}