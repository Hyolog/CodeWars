using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/583203e6eb35d7980400002a/solutions/csharp"/>
    [TestClass]
    public static class CountTheSmileyFaces
    {
        [TestMethod]
        public static void Test()
        {
        }

        public static int CountSmileys(string[] smileys)
        {
            var countOfSmileyFaces = 0;

            foreach (var smiley in smileys)
            {
                if (IsSmilyeFace(smiley))
                {
                    countOfSmileyFaces++;
                }
            }

            return countOfSmileyFaces;
        }

        public static bool IsSmilyeFace(string faceString)
        {
            if (faceString.Length == 2 && HaveEyesAndMouth(faceString))
            {
                return true;
            }
            else if (faceString.Length == 3 && HaveEyesAndMouth(faceString) && HaveNoseOnMiddle(faceString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HaveEyesAndMouth(string faceString)
        {
            if ((faceString.StartsWith(":") || faceString.StartsWith(";")) && (faceString.EndsWith(")") || faceString.EndsWith("D")))
            {
                return true;
            }

            return false;
        }

        public static bool HaveNoseOnMiddle(string faceString)
        {
            if (faceString[1].Equals('-') || faceString[1].Equals('~'))
            {
                return true;
            }

            return false;
        }
    }
}