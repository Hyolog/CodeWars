using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/585b989c45376c73e30000d1/train/csharp"/>
    [TestClass]
    public class ChristmasPresentCalculator
    {
        [TestMethod]
        public void Test()
        {
            Dictionary<String, int> ddict = new Dictionary<String, int>() { { "Santa", 1 }, { "elf_0", 2 } };
            string[] ppres = new string[15] 
            {
                "18:58:15",
                "04:43:45",
                "23:45:53",
                "15:56:11",
                "08:58:17",
                "09:12:10",
                "22:50:47",
                "17:18:19",
                "08:35:16",
                "17:57:55",
                "14:36:52",
                "22:03:55",
                "17:58:06",
                "06:13:04",
                "13:17:51"
            };
            Assert.AreEqual(7, CountPresents(ddict, ppres));

            //ppres = new string[3] { "12:00:00", "04:00:00", "02:00:00" };
            //Assert.AreEqual(3, CountPresents(ddict, ppres));

            //string[] ppres = new string[3] { "12:00:00", "04:00:00", "12:00:00" };
            //Assert.AreEqual(2, CountPresents(ddict, ppres));

            //ddict = new Dictionary<String, int>() { { "Santa", 1 }, { "elf_1", 1 }, { "elf_2", 2 } };
            //ppres = new string[6] { "01:00:00", "06:00:00", "12:00:00", "18:00:00", "24:00:00", "36:00:00" };
            //Assert.AreEqual(5, CountPresents(ddict, ppres));

            //ppres = new string[0];
            //Assert.AreEqual(0, CountPresents(ddict, ppres));
        }

        public int CountPresents(Dictionary<String, int> prod, string[] presents)
        {
            presents = presents.OrderByDescending(d => d).ToArray();
            var index = presents.Length - 1;
            var latestSecond = 0;

            foreach (var item in prod)
            {
                var power = item.Value * 24 * 60 * 60;

                while (power > 0)
                {
                    if (index < 0)
                        break;

                    var needSecond = latestSecond == 0 ? ConvertToSecond(presents[index]) : latestSecond;

                    if (power >= needSecond)
                    {
                        index--;
                        latestSecond = 0;
                    }
                    else
                    {
                        latestSecond = needSecond - power;
                    }

                    power -= needSecond;
                }
            }

            return presents.Length - 1 - index;
        }

        private int ConvertToSecond (string time)
        {
            var items = time.Split(':');

            var result = 0;

            result += int.Parse(items[2]);

            result += int.Parse(items[1]) * 60;

            result += int.Parse(items[0]) * 60 * 60;

            return result;
        }
    }
}
