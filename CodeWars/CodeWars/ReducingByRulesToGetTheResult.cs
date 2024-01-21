using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/585ba6dff59b3cef3f000132/train/csharp"/>
    [TestClass]
    public class ReducingByRulesToGetTheResult
    {
        [TestMethod]
        public void Test()
        {
            Func<double, double, double>[] rules = new Func<double, double, double>[] {
                (a, b) => a + b,
                (a, b) => a - b
            };

            Assert.AreEqual(5.0, ReduceByRules(new[] { 2.0, 2.0, 3.0, 4.0 }, rules));

            rules = new Func<double, double, double>[] { (a, b) => a + b };

            Assert.AreEqual(6.0, ReduceByRules(new[] { 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(8.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(10.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(12.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));

            rules = new Func<double, double, double>[] { (a, b) => a + b, (a, b) => a - b, (a, b) => a * b };

            Assert.AreEqual(2.0, ReduceByRules(new[] { 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(4.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(6.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));
            Assert.AreEqual(4.0, ReduceByRules(new[] { 2.0, 2.0, 2.0, 2.0, 2.0, 2.0 }, rules));

            rules = new Func<double, double, double>[] { (a, b) => Math.Min(a, b), (a, b) => Math.Max(a, b) };

            Assert.AreEqual(3.3, ReduceByRules(new[] { 1.3, 2.0, 3.3 }, rules));
            Assert.AreEqual(2.2, ReduceByRules(new[] { 4.1, 2.2, 2.1, 2.5 }, rules));
            Assert.AreEqual(8.0, ReduceByRules(new[] { 8.0, 8.1, 4.1, 12.0, 2.0 }, rules));
            Assert.AreEqual(2.4, ReduceByRules(new[] { 2.9, 2.8, 2.7, 2.6, 2.5, 2.4 }, rules));
        }

        public static double ReduceByRules(double[] numbers, Func<double, double, double>[] rules)
        {
            var ruleIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                ruleIndex = ruleIndex % rules.Length;

                numbers[i + 1] = calculate(numbers[i], numbers[i + 1], rules[ruleIndex]);

                ruleIndex++;
            }

            return numbers[numbers.Length - 1];
        }

        public static double calculate(double a, double b, Func<double, double, double> rule)
        {
            return rule(a, b);
        }
    }
}
