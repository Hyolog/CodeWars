using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59d9d8cb27ee005972000045/train/csharp"/>
    [TestClass]
    public class Catalog
    {
        public static string s =
        "<prod><name>drill</name><prx>99</prx><qty>5</qty></prod>\n\n" +
        "<prod><name>hammer</name><prx>10</prx><qty>50</qty></prod>\n\n" +
        "<prod><name>screwdriver</name><prx>5</prx><qty>51</qty></prod>\n\n" +
        "<prod><name>table saw</name><prx>1099.99</prx><qty>5</qty></prod>\n\n" +
        "<prod><name>saw</name><prx>9</prx><qty>10</qty></prod>\n\n" +
        "<prod><name>chair</name><prx>100</prx><qty>20</qty></prod>\n\n" +
        "<prod><name>fan</name><prx>50</prx><qty>8</qty></prod>\n\n" +
        "<prod><name>wire</name><prx>10.8</prx><qty>15</qty></prod>\n\n" +
        "<prod><name>battery</name><prx>150</prx><qty>12</qty></prod>\n\n" +
        "<prod><name>pallet</name><prx>10</prx><qty>50</qty></prod>\n\n" +
        "<prod><name>wheel</name><prx>8.80</prx><qty>32</qty></prod>\n\n" +
        "<prod><name>extractor</name><prx>105</prx><qty>17</qty></prod>\n\n" +
        "<prod><name>bumper</name><prx>150</prx><qty>3</qty></prod>\n\n" +
        "<prod><name>ladder</name><prx>112</prx><qty>12</qty></prod>\n\n" +
        "<prod><name>hoist</name><prx>13.80</prx><qty>32</qty></prod>\n\n" +
        "<prod><name>platform</name><prx>65</prx><qty>21</qty></prod>\n\n" +
        "<prod><name>car wheel</name><prx>505</prx><qty>7</qty></prod>\n\n" +
        "<prod><name>bicycle wheel</name><prx>150</prx><qty>11</qty></prod>\n\n" +
        "<prod><name>big hammer</name><prx>18</prx><qty>12</qty></prod>\n\n" +
        "<prod><name>saw for metal</name><prx>13.80</prx><qty>32</qty></prod>\n\n" +
        "<prod><name>wood pallet</name><prx>65</prx><qty>21</qty></prod>\n\n" +
        "<prod><name>circular fan</name><prx>80</prx><qty>8</qty></prod>\n\n" +
        "<prod><name>exhaust fan</name><prx>62</prx><qty>8</qty></prod>\n\n" +
        "<prod><name>cattle prod</name><prx>990</prx><qty>2</qty></prod>\n\n" +
        "<prod><name>window fan</name><prx>62</prx><qty>8</qty></prod>";

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("ladder > prx: $112 qty: 12", CatalogFunc(s, "ladder"));
            Assert.AreEqual("table saw > prx: $1099.99 qty: 5\nsaw > prx: $9 qty: 10\nsaw for metal > prx: $13.80 qty: 32", CatalogFunc(s, "saw"));
            Assert.AreEqual("Nothing", CatalogFunc(s, "nails"));
        }

        public static string CatalogFunc(string s, string article)
        {
            var result = new List<string>();

            var lines = s.Split("\n\n");

            foreach (var line in lines)
            {
                if (line.Contains(article))
                {
                    var startIndex = line.IndexOf("<name>") + "<name>".Length;
                    var endIndex = line.IndexOf("</name>");
                    var name = line.Substring(startIndex, endIndex - startIndex);

                    startIndex = line.IndexOf("<prx>") + "<prx>".Length;
                    endIndex = line.IndexOf("</prx>");
                    var prx = line.Substring(startIndex, endIndex - startIndex);

                    startIndex = line.IndexOf("<qty>") + "<qty>".Length;
                    endIndex = line.IndexOf("</qty>");
                    var qty = line.Substring(startIndex, endIndex - startIndex);

                    result.Add($"{name} > prx: ${prx} qty: {qty}");
                }
            }

            return result.Count == 0 ? "Nothing" : string.Join("\n", result);
        }
    }
}
