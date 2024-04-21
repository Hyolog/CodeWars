using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58e8f020fd89eaa1cf0000c2/train/csharp"/>
    /// Todo : 다시 풀어보기, 문의 남김 https://www.codewars.com/kata/58e8f020fd89eaa1cf0000c2/discuss
    [TestClass]
    public class ClockPatience
    {
        private static string[] suit = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private static List<string> cards = new List<string>(suit.Concat(suit).Concat(suit).Concat(suit));

        [TestMethod]
        public void Test()
        {
            var notShuffled = new List<string>(cards);
            Console.WriteLine($"IN: cards = {string.Join(", ", notShuffled)}");
            Assert.AreEqual(48, Patience(notShuffled.ToArray()));

            var shuffled = new List<string>(cards);
            Shuffle(shuffled);
            Console.WriteLine($"IN: cards = {string.Join(", ", shuffled)}");
            Patience(shuffled.ToArray());

            //var shuffled2 = new List<string> { "5", "J", "K", "7", "4", "A", "K", "9", "8", "J", "2", "10", "2", "3", "3", "Q", "8", "5", "10", "5", "7", "4", "8", "K", "2", "J", "2", "8", "J", "4", "9", "9", "K", "10", "6", "9", "Q", "A", "3", "7", "A", "Q", "10", "A", "Q", "6", "3", "6", "7", "5", "4", "6" };
            //Assert.AreEqual(4, Patience(shuffled2.ToArray()));
        }

        public static void Shuffle<T>(List<T> deck)
        {
            var rnd = new Random();
            for (int n = deck.Count - 1; n > 0; --n)
            {
                int k = rnd.Next(n + 1);
                T temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }

        private static Dictionary<int, Queue<string>> SetCards(string[] cards)
        {
            // int : 시간(1~13), Queue<string> : 카드더미
            var result = new Dictionary<int, Queue<string>>();
            var index = 1;

            foreach (var card in cards)
            {
                if (result.TryGetValue(index, out var stack))
                {
                    stack.Enqueue(card);
                }
                else
                {
                    var stk = new Queue<string>();
                    stk.Enqueue(card);
                    result.Add(index, stk);
                }

                index++;

                if (index > 13)
                    index = 1;
            }

            return result;
        }

        public static int Patience(string[] cards)
        {
            var cardSet = SetCards(cards);

            // Play game
            var time = 13;

            while (cardSet.TryGetValue(time, out var dec))
            {
                if (dec.Count == 0)
                    break;

                var card = dec.Dequeue();

                switch (card)
                {
                    case "A": time = 1; break;
                    case "2": time = 2; break;
                    case "3": time = 3; break;
                    case "4": time = 4; break;
                    case "5": time = 5; break;
                    case "6": time = 6; break;
                    case "7": time = 7; break;
                    case "8": time = 8; break;
                    case "9": time = 9; break;
                    case "10": time = 10; break;
                    case "J": time = 11; break;
                    case "Q": time = 12; break;
                    case "K": time = 13; break;
                }
            }

            return cardSet.Select(d => d.Value).Sum(d => d.Count);
        }
    }
}
