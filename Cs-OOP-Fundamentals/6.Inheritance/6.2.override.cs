class Person
{
    public virtual void SayHello()
    {
        Console.WriteLine("Hello from Person");
    }
}

class Student : Person
{
    public override void SayHello()
    {
        Console.WriteLine("Hello from Student");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.SayHello();
    }
}