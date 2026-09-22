using System;
using System.Linq;
using System.Collections.Generic;

// OrderBy() is used to sort items in ascending order.
class OrderBy
{
    static void Main(string[] args)
    {
        List<int> numbers = [5, 2, 8, 1, 3];

        var sortedNumbers = numbers.OrderBy(n => n);
        // OrderByDescending - in Descending Order 

        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}