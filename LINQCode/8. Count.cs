using System;
using System.Linq;
using System.Collections.Generic;

// Count() is used to count the number of items in a collection.
class Count
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        int count = numbers.Count();

        Console.WriteLine(count);
    }
}