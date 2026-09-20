using System;
using System.Linq;
using System.Collections.Generic;

// Sum() -> is used to add all the numbers in a collection.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        int total = numbers.Sum();

        Console.WriteLine(total);
    }
}