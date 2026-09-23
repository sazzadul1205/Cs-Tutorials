class Person
{
    public string? Name;

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class Student : Person
{
    public int StudentId;
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Sazzadul";
        student.StudentId = 1205;

        student.SayHello();

        Console.WriteLine(student.Name);
        Console.WriteLine(student.StudentId);
    }
}