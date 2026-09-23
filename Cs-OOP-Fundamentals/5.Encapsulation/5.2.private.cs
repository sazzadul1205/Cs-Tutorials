class Person
{
    private string? name;

    public void SetName(string value)
    {
        name = value;
    }

    public void ShowName()
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.SetName("Sazzadul");
        person.ShowName();
    }
}