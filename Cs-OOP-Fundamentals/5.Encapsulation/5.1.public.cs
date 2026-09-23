class Person
{
    public string? Name;
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Name = "Sazzadul";

        Console.WriteLine(person.Name);
    }
}