// https://www.codewars.com/kata/552c028c030765286c00007d/solutions/csharp

using System;

public class IQ
{
    public static int Test(string numbers)
    {
        var nums = numbers.Split(' ').Select(num => int.Parse(num));

        var oddCount = nums.Count(num => num % 2 != 0);
        var evenCount = nums.Count(num => num % 2 == 0);

        return oddCount > evenCount ? GetIndexOfEvenNum(nums) : GetIndexOfOddNum(nums);
    }

    public static int GetIndexOfOddNum(IEnumerable<int> numbers)
    {
        return numbers.Select((num, index) => new { num, index }).First(d => d.num % 2 != 0).index + 1;
    }

    public static int GetIndexOfEvenNum(IEnumerable<int> numbers)
    {
        return numbers.Select((num, index) => new { num, index }).First(d => d.num % 2 == 0).index + 1;
    }
}