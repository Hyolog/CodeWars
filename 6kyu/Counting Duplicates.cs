//https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
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