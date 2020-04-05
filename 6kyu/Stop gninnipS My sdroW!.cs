//https://www.codewars.com/kata/5264d2b162488dc400000001/solutions/csharp

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        return string.Join(' ', sentence.Split(' ').Select(d => d.Length >= 5 ? new string(d.Reverse().ToArray()) : d));
    }
}