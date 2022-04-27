using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5d23d89906f92a00267bb83d/train/csharp"/>
    [TestClass]
    public class NewCashierDoesNotKnowAboutSpaceOrShift
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
                GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
            Assert.AreEqual("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
                GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));
        }

        public static string GetOrder(string input)
        {
            var menus = new string[8] { "Burger", "Fries", "Chicken", "Pizza", "Sandwich", "Onionrings", "Milkshake", "Coke" };
            var result = new StringBuilder();

            foreach (var menu in menus)
            {
                var countOfMenu = Regex.Matches(input, menu, RegexOptions.IgnoreCase);

                for (int i = 0; i < countOfMenu.Count; i++)
                    result.Append($"{menu} ");
            }

            return result.ToString().Trim();
        }
    }
}
