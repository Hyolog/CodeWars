using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/596e91b48c92ceff0c00001f/train/csharp"/>
    [TestClass]
    public class WordsToHex
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new string[] { "#48656c", "#6d7900", "#6e616d", "#697300", "#476172", "#616e64", "#490000", "#6c696b", "#636865" }, WordsToHexFunc("Hello, my name is Gary and I like cheese."));
            CollectionAssert.AreEqual(new string[] { "#303132" }, WordsToHexFunc("0123456789"));
            CollectionAssert.AreEqual(new string[] { "#546869" }, WordsToHexFunc("ThisIsOneLongSentenceThatConsistsOfWords"));
            CollectionAssert.AreEqual(new string[] { "#426c61", "#626c61", "#626c61", "#626c61" }, WordsToHexFunc("Blah blah blah blaaaaaaaaaaaah"));
            CollectionAssert.AreEqual(new string[] { "#262626", "#242424", "#5e5e5e", "#404040", "#282928" }, WordsToHexFunc("&&&&& $$$$$ ^^^^^ @@@@@ ()()()()("));
        }

        public static string[] WordsToHexFunc(string input)
        {
            List<string> words = ExtractWords(input);
            return words.ConvertAll(Func).ToArray();
        }

        private static List<string> ExtractWords(string input)
        {
            List<string> words = new List<string>();
            string word = "";

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) && word != "")
                {
                    words.Add(word);
                    word = "";
                }
                else if (!char.IsWhiteSpace(c))
                {
                    word += c;
                }
            }

            if (word != "")
                words.Add(word);

            return words;
        }

        public static string Func(string word)
        {
            string hexValue = "#";
            for (int i = 0; i < 3; i++)
            {
                if (i < word.Length)
                {
                    hexValue += Convert.ToInt32(word[i]).ToString("x2");
                }
                else
                {
                    hexValue += "00";
                }
            }
            return hexValue;
        }
    }
}
