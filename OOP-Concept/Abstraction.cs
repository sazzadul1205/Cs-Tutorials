abstract class Person
{
    public abstract void Name();
}

class Anna: Person
{
    public override void Name()
    {
        Console.WriteLine("Anna I am 10 years Old");
    }
}


class Inheritance
{
    public static void Main(string[] args)
    {
        Person person = new Anna();

        person.Name();
    }
}