using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/57d6b40fbfcdc5e9280002ee/train/csharp"/>
    [TestClass]
    public class SpellingBee
    {
        [TestMethod]
        public void Test()
        {
            char[][] hive = new char[][] {
                "bee.bee".ToCharArray(),
                ".e..e..".ToCharArray(),
                ".b..eeb".ToCharArray()
              };

            Assert.AreEqual(5, HowManyBees(hive));

            hive = new char[][] {
                "bee.bee".ToCharArray(),
                "e.e.e.e".ToCharArray(),
                "eeb.eeb".ToCharArray()
              };

            Assert.AreEqual(8, HowManyBees(hive));

            hive = new char[][] {
                "beebe..e.".ToCharArray(),
                "bbee.ee..".ToCharArray(),
                "ebe.ee.b.".ToCharArray(),
                "be..e.ebe".ToCharArray(),
                "e..bb.eee".ToCharArray(),
                "bee.e..eb".ToCharArray(),
                "eee..bbe.".ToCharArray(),
                "beebe..e.".ToCharArray(),
                "e..ee.bbe".ToCharArray()
              };

            Assert.AreEqual(10, HowManyBees(hive));
        }

        public static char lastWord = default;
        public static char lastLastWord = default;

        private static void InitWord()
        {
            lastWord = default;
            lastLastWord = default;
        }

        private static int CountBee(char word)
        {
            if (word == '.')
            {
                InitWord();
                return 0;
            }
            else if (word == 'e' && lastWord == 'e' && lastLastWord == 'b')
            {
                lastLastWord = lastWord;
                lastWord = word;

                return 1;
            }
            else
            {
                lastLastWord = lastWord;
                lastWord = word;

                return 0;
            }
        }

        public static int HowManyBees(char[][] hive)
        {
            if (hive == null || hive.Length == 0)
                return 0;

            var countOfBees = 0;
            var rowCount = hive.Length;
            var colCount = hive[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    // 가로 좌우
                    var word = hive[i][j];

                    countOfBees += CountBee(word);
                }

                InitWord();
            }

            InitWord();

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    // 가로 우좌
                    var word = hive[i][colCount - 1 - j];

                    countOfBees += CountBee(word);
                }

                InitWord();
            }

            InitWord();

            for (int j = 0; j < colCount; j++)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    // 세로 상하
                    var word = hive[i][j];

                    countOfBees += CountBee(word);
                }

                InitWord();
            }

            InitWord();

            for (int j = 0; j < colCount; j++)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    // 세로 하상
                    var word = hive[rowCount - 1 - i][j];

                    countOfBees += CountBee(word);
                }

                InitWord();
            }

            return countOfBees;
        }
    }
}
