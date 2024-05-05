using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59971e64bfccc70748000068/train/csharp"/>
    [TestClass]
    public class SequenceConvergence
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(5, convergence(3));
            Assert.AreEqual(6, convergence(5));
            Assert.AreEqual(5, convergence(10));
            Assert.AreEqual(2, convergence(15));
            Assert.AreEqual(29, convergence(500));
            Assert.AreEqual(283, convergence(5000));
        }

        public static int convergence(int n)
        {
            var index = n;
            var result = 1;
            var pivot = 1;


            while (true)
            {
                index = GetNext(index);

                while (pivot < index)
                {
                    pivot = GetNext(pivot);
                }

                if (index == pivot)
                {
                    break;
                }

                result++;
            }

            return result;
        }

        public static int GetNext(int num)
        {
            if (num < 10)
            {
                return num + num;
            }
            else
            {
                var backup = num;
                int multiply = 1;

                while (num > 0)
                {
                    int digit = num % 10;

                    if (digit != 0)
                    {
                        multiply *= digit;
                    }

                    num /= 10;
                }

                return backup + multiply;
            }
        }
    }
}
