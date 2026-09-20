// Class: Blueprint
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
    }

    // Constructor 3
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

     public void Hello()
    {
        Console.WriteLine($"Hello My Name is {Name} and i am {Age} Years Old ");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Hello();

        Person person2 = new Person("Pritom");
        person2.Hello();

        Person person3 = new Person("Pritom", 20);
        person3.Hello();
    }
}