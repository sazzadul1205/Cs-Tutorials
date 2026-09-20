using System;
using System.Linq;
using System.Collections.Generic;

// GroupBy() -> is used to group items based on a specific value or condition.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];

        var groups = numbers.GroupBy(n => n % 2);

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key);

            foreach (int number in group)
            {
                Console.WriteLine(number);
            }
        }
    }
}