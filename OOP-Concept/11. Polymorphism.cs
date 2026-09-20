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
class James: Person
{
    public override void Name()
    {
        Console.WriteLine("Hello James!");
    }
}


class Inheritance
{
    public static void Main(string[] args)
    {

        Person person1 = new Anna();
        Person person2 = new James();

        person1.Name();
        person2.Name();
    }
}