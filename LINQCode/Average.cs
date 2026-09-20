using System;
using System.Linq;
using System.Collections.Generic;

// Average() -> is used to calculate the average of the numbers in a collection.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        double average = numbers.Average();

        Console.WriteLine(average);
    }
}