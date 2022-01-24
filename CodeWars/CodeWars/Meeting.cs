using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/59df2f8f08c6cec835000012/train/csharp"/>
    /// TODO : Linq로 다시 풀어보기
    [TestClass]
    public class Meeting
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)",
                MeetingFunc("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn"));
            Assert.AreEqual("(BELL, MEGAN)(CORNWELL, AMBER)(DORNY, JAMES)(DORRIES, PAUL)(GATES, JOHN)(KERN, ANN)(KORN, ANNA)(META, ALEX)(RUSSEL, ELIZABETH)(STEVE, LEWIS)(WAHL, MICHAEL)",
                MeetingFunc("John: Gates; Michael: Wahl; Megan: Bell; Paul: Dorries; James: Dorny; Lewis: Steve; Alex: Meta; Elizabeth: Russel; Anna: Korn; Ann: Kern; Amber: Cornwell")); 
            Assert.AreEqual("(ARNO, ALEX)(ARNO, HALEY)(BELL, SARAH)(CORNWELL, ALISSA)(DORNY, PAUL)(DORRIES, ANDREW)(KERN, ANN)(KERN, MADISON)",
                MeetingFunc("Alex:Arno;Alissa:Cornwell;Sarah:Bell;Andrew:Dorries;Ann:Kern;Haley:Arno;Paul:Dorny;Madison:Kern"));
        }

        public static string MeetingFunc(string s)
        {
            var nameList = new List<KeyValuePair<string, string>>();
            var names = s.ToUpper().Split(';');

            foreach (var name in names)
            {
                var firstName = name.Split(':')[0].Trim();
                var lastName = name.Split(':')[1].Trim();

                nameList.Add(new KeyValuePair<string, string>(firstName, lastName));
            }

            var a = nameList.OrderBy(d => d.Value).ThenBy(d => d.Key);
            var b = a.Select(d => $"({d.Value}, {d.Key})");
            return string.Join("", b);
        }
    }
}
