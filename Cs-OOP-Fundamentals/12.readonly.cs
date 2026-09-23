using System;

class Person
{
    public readonly string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John");

        Console.WriteLine(person.Name);
    }
}