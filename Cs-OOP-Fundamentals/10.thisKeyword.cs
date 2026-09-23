using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public void ShowInfo()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Age);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John", 20);

        person.ShowInfo();
    }
}