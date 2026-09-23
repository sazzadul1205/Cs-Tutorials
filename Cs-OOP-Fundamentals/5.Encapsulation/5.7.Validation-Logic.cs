class Person
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Age = 20;

        Console.WriteLine(person.Age);

        person.Age = -10;

        Console.WriteLine(person.Age);
    }
}