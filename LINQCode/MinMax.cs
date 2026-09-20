using System;
using System.Linq;
using System.Collections.Generic;

// Min() -> is used to find the smallest value in a collection.
// Max() is used to find the largest value in a collection.
class MinMax
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 5, 40, 30];

        int smallest = numbers.Min();
        int largest = numbers.Max();

        Console.WriteLine(smallest);
        Console.WriteLine(largest);
    }
}