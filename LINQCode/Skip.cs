using System;
using System.Linq;
using System.Collections.Generic;

// Skip() is used to skip a specified number of items from the beginning of a collection.
class Skip
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        var result = numbers.Skip(2);

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}