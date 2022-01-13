using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/564057bc348c7200bd0000ff/train/csharp"/>
    /// TODO : 다시 풀어보기. hint : for (var i = 0; n > 0; i++)
    [TestClass]
    public class ARuleOfDivisibilityBy13
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Thirt(8529), 79);
            Assert.AreEqual(Thirt(85299258), 31);
            Assert.AreEqual(Thirt(5634), 57);
            Assert.AreEqual(Thirt(1111111111), 71);
            Assert.AreEqual(Thirt(987654321), 30);
        }

        public static long Thirt(long n)
        {
            long tempResult = 0;

            while (tempResult != n)
            {
                tempResult = n;
                n = GetNextNumber(n);
            }

            return n;
        }

        private static long GetNextNumber(long n)
        {
            int[] reminders = new int[6] { 1, 10, 9, 12, 3, 4 };
            var reminderindex = 0;
            long result = 0;
            var number = n.ToString();

            for (var i = number.Length - 1; i >= 0; i--)
            {
                var digit = int.Parse(number[i].ToString());

                if (reminderindex > 5)
                    reminderindex = 0;

                var reminder = reminders[reminderindex];

                result += digit * reminder;
                reminderindex++;
            }

            return result;
        }
    }
}
