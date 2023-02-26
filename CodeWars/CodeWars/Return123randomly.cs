using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/593e84f16e836ca9a9000054/train/csharp"/>
    [TestClass]
    public class Return123randomly
    {
        [TestMethod]
        public void Test()
        {
        }

        public static int OneTwoThree()
        {
            var a = Preloaded.OneTwo();
            var b = Preloaded.OneTwo();

            if (a == 1 && b == 2)
                return 1;
            else if (a == 2 && b == 1)
                return 2;
            else if (a == 1 && b == 1)
                return 3;
            else
                return OneTwoThree();
        }
    }

    public static class Preloaded
    {
        static int num = 0;

        public static int OneTwo()
        {
            if (num > 1)
                num = 0;

            return num;
        }
    }
}
