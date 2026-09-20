using System;

// Class: Blueprint
class Person
{
    // Instance method
    public void HelloInstance()
    {
        Console.WriteLine("Hello from instance method!");
    }

    // Static method
    public static void HelloStatic()
    {
        Console.WriteLine("Hello from static method!");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Instance member usage
        Person person = new Person();
        person.HelloInstance();

        // Static member usage
        Person.HelloStatic();
    }
}