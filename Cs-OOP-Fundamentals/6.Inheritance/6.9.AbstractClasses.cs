abstract class Person
{
    public string Name;

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class Student : Person
{
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Sazzadul";

        student.SayHello();

        Console.WriteLine(student.Name);
    }
}