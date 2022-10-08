using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5938f5b606c3033f4700015a/train/csharp"/>
    /// TODO : 다시 풀어보기
    [TestClass]
    public class AlphabetWarAirstrike
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("Let's fight again!", AlphabetWar("n*d*"));
            Assert.AreEqual("Let's fight again!", AlphabetWar("d**bi"));
            Assert.AreEqual("Right side wins!", AlphabetWar("gmvq"));
            Assert.AreEqual("Right side wins!", AlphabetWar("w*mqjs*"));
            Assert.AreEqual("Right side wins!", AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", AlphabetWar("****"));
            Assert.AreEqual("Let's fight again!", AlphabetWar("z*dq*mw*pb*s"));
            Assert.AreEqual("Let's fight again!", AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", AlphabetWar("zz*zzs"));
            Assert.AreEqual("Left side wins!", AlphabetWar("*wwwwww*z*"));
            Assert.AreEqual("Left side wins!", AlphabetWar("fs"));
            Assert.AreEqual("Left side wins!", AlphabetWar("*sp"));
            Assert.AreEqual("Let's fight again!", AlphabetWar("*dbd"));
            Assert.AreEqual("Right side wins!", AlphabetWar("yqugz"));
            Assert.AreEqual("Right side wins!", AlphabetWar("mkq*u*"));
            Assert.AreEqual("Left side wins!", AlphabetWar("zrpitz*"));
        }

        public static string AlphabetWar(string fight)
        {
            var fightArray = fight.ToCharArray();
            var left = new char[4] { 'w', 'p', 'b', 's' };
            var right = new char[4] { 'm', 'q', 'd', 'z' };

            if (fightArray[0] == '*')
            {
                if (fightArray[1] != '*')
                    fightArray[1] = '-';
            }
            if (fightArray[fightArray.Length - 1] == '*')
            {
                if (fightArray[fightArray.Length - 2] != '*')
                    fightArray[fightArray.Length - 2] = '-';
            }

            for (int i = 1; i < fightArray.Length - 1; i++)
            {
                if (fightArray[i] == '*')
                {
                    if (fightArray[i - 1] != '*')
                        fightArray[i - 1] = '-';

                    if (fightArray[i + 1] != '*')
                        fightArray[i + 1] = '-';
                }
            }

            var leftWin = 0;
            var rightWin = 0;

            foreach (var item in fightArray)
            {
                if (left.Contains(item))
                {
                    switch (item)
                    {
                        case 'w': leftWin += 4; break;
                        case 'p': leftWin += 3; break;
                        case 'b': leftWin += 2; break;
                        case 's': leftWin += 1; break;
                        default: break;
                    }
                }
                if (right.Contains(item))
                {
                    switch (item)
                    {
                        case 'm': rightWin += 4; break;
                        case 'q': rightWin += 3; break;
                        case 'd': rightWin += 2; break;
                        case 'z': rightWin += 1; break;
                        default: break;
                    }
                }
            }

            if (leftWin > rightWin)
                return "Left side wins!";
            else if (leftWin < rightWin)
                return "Right side wins!";
            else
                return "Let's fight again!";
        }
    }
}
