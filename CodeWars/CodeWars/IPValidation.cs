using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/515decfd9dcfc23bb6000006/train/csharp"/>
    /// TODO : 정규식으로 풀어보기
    [TestClass]
    public class IPValidation
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(true, is_valid_IP("0.0.0.0"));
            Assert.AreEqual(true, is_valid_IP("12.255.56.1"));
            Assert.AreEqual(true, is_valid_IP("137.255.156.100"));
            Assert.AreEqual(false, is_valid_IP(""));
            Assert.AreEqual(false, is_valid_IP("abc.def.ghi.jkl"));
            Assert.AreEqual(false, is_valid_IP("123.456.789.0"));
            Assert.AreEqual(false, is_valid_IP("12.34.56"));
            Assert.AreEqual(false, is_valid_IP("12.34.56.00"));
            Assert.AreEqual(false, is_valid_IP("12.34.56.7.8"));
            Assert.AreEqual(false, is_valid_IP("12.34.256.78"));
            Assert.AreEqual(false, is_valid_IP("1234.34.56"));
            Assert.AreEqual(false, is_valid_IP("pr12.34.56.78"));
            Assert.AreEqual(false, is_valid_IP("12.34.56.78sf"));
            Assert.AreEqual(false, is_valid_IP("12.34.56 .1"));
            Assert.AreEqual(false, is_valid_IP("12.34.56.-1"));
            Assert.AreEqual(false, is_valid_IP("123.045.067.089"));
        }

        public static bool is_valid_IP(string ipAddres)
        {
            var items = ipAddres.Split('.');

            if (items.Length != 4)
                return false;

            foreach (var item in items)
            {
                if (item.Length > 1 && item[0] == '0')
                    return false;

                if (item.Length != item.Trim().Length)
                    return false;

                if (int.TryParse(item, out var value))
                {
                    if (value < 0 || value > 255)
                        return false;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
