interface IPerson
{
    void Name();
}

class Anna : IPerson
{
    public void Name()
    {
        Console.WriteLine("I am Anna");
    }
}

class Interfaces
{
    public static void Main(string[] args)
    {
        Anna person = new Anna();

        person.Name();
    }
}