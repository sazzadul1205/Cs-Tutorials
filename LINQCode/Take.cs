using System;
using System.Linq;
using System.Collections.Generic;

// Take() -> is used to take a specified number of items from the beginning of a collection.
class Take
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        var result = numbers.Take(3);

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}