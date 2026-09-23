using System;

class Person
{
    public string Name;
    public int Age;

    // Constructor 1
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Constructor 2
    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    // Constructor 3
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();

        Person person2 = new Person("John");

        Person person3 = new Person("Mike", 25);

        Console.WriteLine(person1.Name);
        Console.WriteLine(person2.Name);
        Console.WriteLine(person3.Name);
    }
}