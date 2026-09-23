class Person
{
    public void SayHello()
    {
        Console.WriteLine("Hello from Person");
    }
}

class Student : Person
{
    public void SayHelloAsStudent()
    {
        base.SayHello();

        Console.WriteLine("Hello from Student");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.SayHelloAsStudent();
    }
}