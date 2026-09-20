using System;
using System.Linq;
using System.Collections.Generic;

// Single() -> is used to get the only item that matches a condition.
class Single
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];

        int number = numbers.Single(n => n == 3);

        Console.WriteLine(number);
    }
}