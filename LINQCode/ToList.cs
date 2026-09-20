using System;
using System.Linq;
using System.Collections.Generic;

// ToList() is used to convert the LINQ result into a List<T>.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];

        List<int> evenNumbers = numbers
            .Where(n => n % 2 == 0)
            .ToList();

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}