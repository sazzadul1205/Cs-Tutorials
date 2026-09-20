class Person
{
    public virtual void Name()
    {
        Console.WriteLine("Hello");
    }
}

class Anna: Person
{
    public override void Name()
    {
        Console.WriteLine("Hello Anna!");
    }
}


class Inheritance
{
    public static void Main(string[] args)
    {

        Anna person = new Anna();

        person.Name();
    }
}