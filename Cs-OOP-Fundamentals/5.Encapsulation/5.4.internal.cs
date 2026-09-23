class Person
{
    internal string? Name;
}

class Student
{
    public void ShowName()
    {
        Person person = new Person();

        person.Name = "Sazzadul";

        Console.WriteLine(person.Name);
    }
}