using System;
using System.Linq;
using System.Collections.Generic;

// Distinct() -> is used to remove duplicate items from a collection.
class Distinct
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 2, 3, 3, 3, 4, 5];

        var result = numbers.Distinct();

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}