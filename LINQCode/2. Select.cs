using System;
using System.Linq;
using System.Collections.Generic;

// Select() -> is used to transform each item in a collection into something else.
class Select
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];

        var squares = numbers.Select(n => n * n);

        foreach (int number in squares)
        {
            Console.WriteLine(number);
        }
    }
}