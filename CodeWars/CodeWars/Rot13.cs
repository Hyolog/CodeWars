using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp"/>
    [TestClass]
    public class Rot13
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("grfg", Rot13Func("test"));
            Assert.AreEqual("Grfg", Rot13Func("Test"));
            Assert.AreEqual("G3rf2g*", Rot13Func("T3es2t*"));
        }

        public string Rot13Func(string message)
        {
            var tempResult = message.ToCharArray();

            for (int i = 0; i < tempResult.Length; i++)
            {
                if (IsCapitalLetter(tempResult[i]))
                    tempResult[i] = GetCapitalLetterRot(tempResult[i]);
                else if (IsSmallLetter(tempResult[i]))
                    tempResult[i] = GetSmallLetterRot(tempResult[i]);
            }

            return new string(tempResult);
        }

        private bool IsCapitalLetter(char character)
        {
            return character > 64 && character < 91;
        }

        private bool IsSmallLetter(char character)
        {
            return character > 96 && character < 123;
        }

        private char GetCapitalLetterRot(char character)
        {
            var tempCharacter = character + 13;

            if (tempCharacter > 90)
                tempCharacter -= 26;

            return (char)tempCharacter;
        }

        private char GetSmallLetterRot(char character)
        {
            var tempCharacter = character + 13;

            if (tempCharacter > 122)
                tempCharacter -= 26;

            return (char)tempCharacter;
        }
    }
}
