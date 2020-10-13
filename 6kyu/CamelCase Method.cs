//https://www.codewars.com/kata/587731fda577b3d1b0001196/solutions/csharp

/*Write simple.camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. 
All words must have their first letter capitalized without spaces.*/

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public static class Kata
{
    [TestMethod]
    public void BasicTests()
    {
        Assert.AreEqual("TestCase", "test case".CamelCase());
        Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
        Assert.AreEqual("SayHello", "say hello".CamelCase());
        Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
        Assert.AreEqual("", "".CamelCase());
    }

    public static string CamelCase(this string str)
    {
        string result = "";

        foreach (var word in str.Split(' '))
        {
            result += ToCamel(word);
        }

        return result;
    }

    public static string ToCamel(string word)
    {
        return string.IsNullOrWhiteSpace(word) ? "" : word[0].ToString().ToUpper() + word.Substring(1).ToLower();
    }
}