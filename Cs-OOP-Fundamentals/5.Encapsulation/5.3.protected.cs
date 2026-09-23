class Person
{
    protected string? Name;
}

class Student : Person
{
    public void ShowName()
    {
        Name = "Sazzadul";

        Console.WriteLine(Name);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.ShowName();
    }
}