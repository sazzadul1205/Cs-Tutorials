// Class: Blueprint
class Person
{
    public void Hello()
    {
        Console.WriteLine("Hello!");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Person person = new Person();

        person.Hello();
    }
}