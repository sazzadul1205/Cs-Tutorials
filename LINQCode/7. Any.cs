using System;
using System.Linq;
using System.Collections.Generic;

// Any() is used to check if at least one item matches a condition.
class Any
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];

        bool hasEvenNumber = numbers.Any(n => n % 2 == 0);

        Console.WriteLine(hasEvenNumber);
    }
}