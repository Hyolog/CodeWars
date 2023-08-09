using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/577e277c9fb2a5511c00001d/train/csharp"/>
    [TestClass]
    public class VowelShifting
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("This is a test!", VowelShift("This is a test!", 0));
            Assert.AreEqual("Thes is i tast!", VowelShift("This is a test!", 1));
            Assert.AreEqual("This as e tist!", VowelShift("This is a test!", 3));
        }

        public static string VowelShift(string text, int n)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            List<int> vowelIndices = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(char.ToLower(text[i])))
                    vowelIndices.Add(i);
            }

            char[] shiftedText = text.ToCharArray();

            for (int i = 0; i < vowelIndices.Count; i++)
            {
                int shiftedIndex = (i + n) % vowelIndices.Count;
                if (shiftedIndex < 0)
                    shiftedIndex += vowelIndices.Count;

                shiftedText[vowelIndices[shiftedIndex]] = text[vowelIndices[i]];
            }

            return new string(shiftedText);
        }
    }
}