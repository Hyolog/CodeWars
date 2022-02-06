using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52f78966747862fc9a0009ae/train/csharp"/>
    [TestClass]
    public class ReversePolishNotationCalculator
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(3, evaluate("3"), 0, "Should parse numbers");
            Assert.AreEqual(3.5, evaluate("3.5"), 0, "Should parse float numbers");
            Assert.AreEqual(3, evaluate("1 3 *"), 0, "Should support multiplication");
            Assert.AreEqual(2, evaluate("4 2 /"), 0, "Should support division");
        }

        public double evaluate(String expr)
        {
            if (string.IsNullOrWhiteSpace(expr))
                return 0;

            var stack = new Stack<double>();

            foreach (var item in expr.Split(' '))
            {
                
                if (double.TryParse(item, out var result))
                    stack.Push(result);
                else
                {
                    if (stack.Count > 1)
                    {
                        var num1 = double.Parse(stack.Pop().ToString());
                        var num2 = double.Parse(stack.Pop().ToString());
                        double calculateResult = 0;

                        switch (item)
                        {
                            case "+":
                                calculateResult = num2 + num1; break;
                            case "-":
                                calculateResult = num2 - num1; break;
                            case "*":
                                calculateResult = num2 * num1; break;
                            case "/":
                                calculateResult = num2 / num1; break;
                            default: break;
                        }

                        stack.Push(calculateResult);
                    }
                    else
                        throw new InvalidOperationException();
                }
            }

            return stack.Count == 1 ? stack.Peek() : throw new InvalidOperationException();
        }
    }
}
