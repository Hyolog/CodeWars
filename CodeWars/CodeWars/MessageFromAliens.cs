using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/598980a41e55117d93000015/train/csharp"/>
    [TestClass]
    public class MessageFromAliens
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("hello", Decode(@"]()]|_]]|_]][-]|-|]"));
            Assert.AreEqual("blip", Decode("{|^{|{{|_{]3{"));
            Assert.AreEqual("die stupid people", Decode("..[-.|_.|^....().[-.|^.__..|)...|.|^.|_|..~|~._\\~.__...[-..|.|).."));
            Assert.AreEqual("your brain looks delicious", Decode("'''_\\~'|_|'()'|''('|'|_'[-'|)''__'_\\~'/<'()'()'|_'''__'|\\|'|''/\\'/?']3'__''/?'|_|''()'`/''"));
            Assert.AreEqual("try to find duplicated kata", Decode("}/\\}~|~}/\\}/<}__}|)}}}[-}~|~}/\\}(}|}|_}|^}|_|}|)}__}|)}}}|\\|}|}/=}__}()}}}~|~}__}`/}/?}}~|~}"));

        }

        public static string Decode(string m)
        {
            Dictionary<string, string> cipher = new Dictionary<string, string>()
            {
                { "/\\", "a" },
                { "]3", "b" },
                { "(", "c" },
                { "|)", "d" },
                { "[-", "e" },
                { "/=", "f" },
                { "(_,", "g" },
                { "|-|", "h" },
                { "|", "i" },
                { "_T", "j" },
                { "/<", "k" },
                { "|_", "l" },
                { "|\\/|", "m" },
                { "|\\|", "n" },
                { "()", "o" },
                { "|^", "p" },
                { "()_", "q" },
                { "/?", "r" },
                { "_\\~", "s" },
                { "~|~", "t" },
                { "|_|", "u" },
                { "\\/", "v" },
                { "\\/\\/", "w" },
                { "><", "x" },
                { "`/", "y" },
                { "~/_", "z" },
                { "__", " " }
            };

            string[] arr = m.Split(m[0]);
            string result = string.Join("", arr.Where(s => s != "").Reverse().Select(s => cipher[s]));
            return result;
        }
    }
}