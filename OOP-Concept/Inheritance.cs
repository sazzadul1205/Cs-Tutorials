class Person
{
    public void Name()
    {
        Console.WriteLine("Hello");
    }
}

class Anna: Person
{
    public void Age()
    {
        Console.WriteLine("I am 10 years Old");
    }
}


class Inheritance
{
    public static void Main(string[] args)
    {

        Anna person = new Anna();

        person.Name();
        person.Age();
    }
}