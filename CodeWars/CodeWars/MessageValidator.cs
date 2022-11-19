using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5fc7d2d2682ff3000e1a3fbc/train/csharp"/>
    [TestClass]
    public class MessageValidator
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, isAValidMessage(""));
            Assert.AreEqual(true, isAValidMessage("3hey5hello2hi"));
            Assert.AreEqual(true, isAValidMessage("4code13hellocodewars"));
            Assert.AreEqual(false, isAValidMessage("101010ZCjmUiLiGLAHaGJiVvPnZahWOLFIucBIcSvvuLuTZsLSmLWZAZwZKYVovhqw10101010epcfORYELN1010HGApnTJuXIakChwQBCScBKxZoGJldy10mkUtGxIpjU1010BxHAHKUMDnAxfvdWCGDXajPyAwGWai10qDxTJfJaxt1010zDZjRVpFaS10JtuKESNSegoYFPFvRuvb1010NhuqthNFjfHqbbMBUtErbmxIppGplJ101010101010QUAMqUZnFwvpcsVWBHaLhKwNJflJwNDEZTUwoeYm10DrfblakkyT1010idQUUuQPYPrWeyFTpudheojqDNPYQC10tPONSqKiDi1010OGLkKcvXXZ1010jIxQaLKPsq10MfntmXmcUf"));
        }

        public static bool isAValidMessage(string message)
        {
            int count = 0;

            for (int i = 0; i < message.Length; i++)
            {
                var numLength = 0;
                var startIndex = i;

                if (char.IsDigit(message[i]))
                {
                    if (count != 0)
                        return false;

                    while (i < message.Length && char.IsDigit(message[i]))
                    {
                        numLength++;
                        i++;
                    }

                    i--;
                    var number = message.Substring(startIndex, numLength);
                    count = int.Parse(number);
                }
                else
                {
                    count--;
                }
            }

            return count == 0;
        }
    }
}
