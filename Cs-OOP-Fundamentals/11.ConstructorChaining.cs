using System;

class Person
{
    public string Name;
    public int Age;

    public Person() : this("Unknown", 0)
    {
    }

    public Person(string name) : this(name, 0)
    {
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();
        Person person2 = new Person("John");
        Person person3 = new Person("Mike", 25);

        person1.ShowInfo();
        person2.ShowInfo();
        person3.ShowInfo();
    }
}