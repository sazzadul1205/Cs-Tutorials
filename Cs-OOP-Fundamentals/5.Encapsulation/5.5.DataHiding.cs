class Person
{
    public int Age;
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Age = -20;

        Console.WriteLine(person.Age);
    }
}