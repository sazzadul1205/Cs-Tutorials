using System;
using System.Linq;
using System.Collections.Generic;

// Where() → selects items that match a condition.
class Where
{
    public static void Main(string[] args)
    {
        List<int> numbers = [1, 5, 6, 77, 890, 22];

        var evenNumbers = numbers.Where(x => x % 2 == 0);

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}