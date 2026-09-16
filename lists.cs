// WorkWithLists();
// WorkWithListOperations();
// WorkWithListSearch();
// WorkWithListSort();
// WorkWithNumbers();
Challenge();

static void WorkWithLists()
{
    List<string> names = ["Alice", "Bob", "James"];

    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

static void WorkWithListOperations()
{
    List<string> names = ["Alice", "Bob", "James"];

    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Bob");

    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}.");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
    Console.WriteLine($"The list has {names.Count} people in it");
}

static void WorkWithListSearch()
{
    List<string> names = ["Alice", "Bob", "James", "Maria", "Bill"];

    var index = names.IndexOf("Bill");

    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    index = names.IndexOf("Not Found");

    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }
}

static void WorkWithListSort()
{
    List<string> names = ["Alice", "Bob", "James", "Maria", "Bill"];

    names.Sort();

    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

static void WorkWithNumbers()
{
    List<int> fibonacciNumbers = [1, 1, 2, 5, 8];

    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);

    foreach (var item in fibonacciNumbers)
    {
        Console.WriteLine(item);
    }
}

static void Challenge()
{
    List<int> fibonacciNumbers = [0, 1];

    for (int i = 2; i <= 20; i++)
    {
        var previous = fibonacciNumbers[i - 1];
        var previous2 = fibonacciNumbers[i - 2];

        fibonacciNumbers.Add(previous + previous2);
    }

    foreach (var number in fibonacciNumbers)
    {
        Console.WriteLine(number);
    }
}
