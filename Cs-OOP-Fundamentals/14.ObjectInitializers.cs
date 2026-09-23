using System;

class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            Name = "John",
            Age = 20
        };

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}