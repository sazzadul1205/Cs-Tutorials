using System;
using System.Linq;
using System.Collections.Generic;

// First() is used to get the first item from a collection.
class First
{
    static void Main(string[] args)
    {
        List<int> numbers = [10, 20, 30, 40, 50];

        int firstNumber = numbers.LastOrDefault();
        // Last() - > gets the Last Item in the Collection 
        // FirstOrDefault() -> gets the First item and if the Collection is empty the return the Default Value
        // LastOrDefault() -> Sam as FirstOrDefault() but for last 

        Console.WriteLine(firstNumber);
    }
}