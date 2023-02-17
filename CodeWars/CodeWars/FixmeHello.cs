using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5b0a80ce84a30f4762000069/train/csharp"/>
    [TestClass]
    public class FixmeHello
    {
        [TestMethod]
        public void Test()
        {
            var dm = new Dinglemouse().SetName("Bob").SetAge(27).SetSex('M');
            var expected = "Hello. My name is Bob. I am 27. I am male.";
            Assert.AreEqual(expected, dm.Hello());

            dm = new Dinglemouse().SetAge(27).SetSex('M').SetName("Bob");
            expected = "Hello. I am 27. I am male. My name is Bob.";
            Assert.AreEqual(expected, dm.Hello());

            dm = new Dinglemouse().SetName("Alice").SetSex('F');
            expected = "Hello. My name is Alice. I am female.";
            Assert.AreEqual(expected, dm.Hello());

            dm = new Dinglemouse().SetName("Batman");
            expected = "Hello. My name is Batman.";
            Assert.AreEqual(expected, dm.Hello());
        }

    }
    public class Dinglemouse
    {
        Dictionary<string, string> helloString = new Dictionary<string, string>();

        public Dinglemouse()
        {
        }

        public Dinglemouse SetAge(int age)
        {
            if (helloString.ContainsKey("age"))
                helloString["age"] = age.ToString();
            else
                helloString.Add("age", age.ToString());

            return this;
        }

        public Dinglemouse SetSex(char sex)
        {
            if (helloString.ContainsKey("sex"))
                helloString["sex"] = sex == 'M' ? "male" : "female";
            else
                helloString.Add("sex", sex == 'M' ? "male" : "female");

            return this;
        }

        public Dinglemouse SetName(string name)
        {
            if (helloString.ContainsKey("name"))
                helloString["name"] = name.ToString();
            else
                helloString.Add("name", name.ToString());

            return this;
        }

        public string Hello()
        {
            var resultString = "Hello.";

            foreach (var item in helloString)
            {
                switch (item.Key)
                {
                    case "age": 
                    case "sex": resultString += $" I am {item.Value}."; break;
                    case "name": resultString += $" My name is {item.Value}."; break;
                    default: break;
                }
            }

            return resultString;
        }
    }
}
