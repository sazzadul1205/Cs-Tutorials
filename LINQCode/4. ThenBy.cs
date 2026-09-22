using System;
using System.Linq;
using System.Collections.Generic;

// 4. ThenBy() is used to sort items after its sorted by OrderBy()
{
    static void Main(string[] args)
    {
        List<string> names = ["John", "Alex", "Bob", "Adam"];

        var sortedNames = names
            .OrderBy(name => name.Length)
            .ThenBy(name => name);

        foreach (int name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}