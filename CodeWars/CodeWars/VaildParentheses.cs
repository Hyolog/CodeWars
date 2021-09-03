using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52774a314c2333f0a7000688/train/csharp"/>
    [TestClass]
    public class VaildParentheses
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(false, ValidParentheses(")"));
            Assert.AreEqual(false, ValidParentheses("("));
            Assert.AreEqual(true, ValidParentheses("()"));
            Assert.AreEqual(false, ValidParentheses(")(((("));
            Assert.AreEqual(true, ValidParentheses("(())((()())())"));
            Assert.AreEqual(true, ValidParentheses("(c(b(a)))(d)"));
        }

        public bool ValidParentheses(string input)
        {
            Console.Write(input);

            var parentheses = new Stack<char>();

            foreach (var parenthesis in input)
            {
                if (!IsParenthesis(parenthesis))
                    continue;

                if (parentheses.Count == 0)
                    parentheses.Push(parenthesis);
                else
                {
                    if (parenthesis.Equals(')'))
                        parentheses.Pop();
                    else
                        parentheses.Push(parenthesis);
                }
            }

            return parentheses.Count == 0;
        }

        private bool IsParenthesis(char character)
        {
            return character.Equals('(') || character.Equals(')');
        }
    }
}
