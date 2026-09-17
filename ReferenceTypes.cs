// Class: Reference Type
class Person
{
    public string Name;
}

class Program
{
    public static void Main(string[] args)
    {
        // Class
        Person person = new Person();
        person.Name = "Pritom";

        // String
        string name = "Pritom";

        // Object
        object number = 100;

        // Array
        int[] numbers = { 10, 20, 30 };

        Console.WriteLine(person.Name);
        Console.WriteLine(name);
        Console.WriteLine(number);
        Console.WriteLine(numbers[0]);
    }
}

