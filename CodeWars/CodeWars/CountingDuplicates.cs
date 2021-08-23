using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/csharp"/>
    [TestClass]
    public class CountingDuplicates
    {
        [TestMethod]
        public void Test()
        {
        }

        public int DuplicateCount(string str)
        {
            var duplicateCheckDic = new Dictionary<char, bool>();

            foreach (var item in str.ToUpper().ToCharArray())
            {
                if (duplicateCheckDic.ContainsKey(item))
                {
                    duplicateCheckDic[item] = true;
                }
                else
                {
                    duplicateCheckDic.Add(item, false);
                }
            }

            return duplicateCheckDic.Where(d => d.Value).Count();
        }
    }
}