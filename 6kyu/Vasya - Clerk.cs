//https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8/train/csharp

using System;

public class Line
{
    public static string Tickets(int[] peopleInLine)
    {
        var countOf25Dollar = 0;
        var countOf50Dollar = 0;
        var countOf100Dollar = 0;

        foreach (var money in peopleInLine)
        {
            if (money == 25)
            {
                countOf25Dollar++;
            }
            else if (money == 50)
            {
                countOf50Dollar++;
                countOf25Dollar--;
            }
            else if (money == 100)
            {
                countOf100Dollar++;
                countOf50Dollar--;
                countOf25Dollar--;
            }

            if (countOf25Dollar < 0 || countOf50Dollar < 0 || countOf100Dollar < 0)
                return "NO";
        }

        return "YES";
    }
}
