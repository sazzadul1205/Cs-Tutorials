using System;
using System.Linq;
using System.Collections.Generic;

// Contains() -> is used to check if a collection contains a specific value.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        bool result = numbers.Contains(30);

        Console.WriteLine(result);
    }
}