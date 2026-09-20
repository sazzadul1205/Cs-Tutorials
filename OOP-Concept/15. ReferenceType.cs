using System;

class Person
{
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Alice";

        Person p2 = p1;  

        p2.Name = "Bob"; 

        Console.WriteLine("p1.Name = " + p1.Name);
        Console.WriteLine("p2.Name = " + p2.Name);
    }
}