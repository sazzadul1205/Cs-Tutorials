using System;
using System.Linq;
using System.Collections.Generic;

// ToArray() is used to convert the LINQ result into an array.
class ToArray
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5];

        int[] evenNumbers = numbers
            .Where(n => n % 2 == 0)
            .ToArray();

        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}