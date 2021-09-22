using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp"/>
    [TestClass]
    public class UniqueInOrder
    {
        [TestMethod]
        public void Test()
        {
        }

        public IEnumerable<T> UniqueInOrderFunc<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>();

            T pivot = default(T);

            foreach (var item in iterable)
            {
                if (pivot == null || !pivot.Equals(item))
                {
                    result.Add(item);
                    pivot = item;
                }
            }

            return result;
        }
    }
}
