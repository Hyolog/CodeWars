//https://www.codewars.com/kata/54da5a58ea159efa38000836/csharp

using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> storage = new Dictionary<int, int>();

            foreach (var item in seq)
            {
                if (storage.ContainsKey(item))
                {
                    storage.Remove(item);
                }
                else
                {
                    storage.Add(item, item);
                }
            }

            return storage.First().Key;
        }
    }
}