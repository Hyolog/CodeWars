using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/55688b4e725f41d1e9000065/train/csharp"/>
    [TestClass]
    public class EvenFibonacciSum
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(10, Fibonacci(10));
        }

        public static long Fibonacci(int max)
        {
            long sum = 0;
            long previous = 0;
            long current = 1;

            while (current < max)
            {
                if (current % 2 == 0)
                {
                    sum += current;
                }

                long next = previous + current;
                previous = current;
                current = next;
            }

            return sum;
        }
    }
}
