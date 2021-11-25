using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/52761ee4cffbc69732000738/train/csharp"/>
    [TestClass]
    public class GoodVsEvil
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Battle Result: Evil eradicates all trace of Good", GoodVsEvilFunc("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
            Assert.AreEqual("Battle Result: Good triumphs over Evil", GoodVsEvilFunc("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
            Assert.AreEqual("Battle Result: No victor on this battle field", GoodVsEvilFunc("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
        }

        public string GoodVsEvilFunc(string good, string evil)
        {
            var goods = good.Split(" ");
            var evils = evil.Split(" ");

            var goodWorth = new int[] { 1, 2, 3, 3, 4, 10 };
            var evilWorth = new int[] { 1, 2, 2, 2, 3, 5, 10 };

            var goodResult = 0;

            for (int i = 0; i < goods.Length; i++)
                goodResult += int.Parse(goods[i].ToString()) * goodWorth[i];

            var evilResult = 0;

            for (int i = 0; i < evils.Length; i++)
                evilResult += int.Parse(evils[i].ToString()) * evilWorth[i];

            if (goodResult == evilResult)
                return "Battle Result: No victor on this battle field";
            else if (goodResult > evilResult)
                return "Battle Result: Good triumphs over Evil";
            else
                return "Battle Result: Evil eradicates all trace of Good";
        }
    }
}
