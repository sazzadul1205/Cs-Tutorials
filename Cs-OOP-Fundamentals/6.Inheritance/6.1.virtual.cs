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
        Person person = new Person();
        Student student = new Student();

        person.SayHello();
        student.SayHello();
    }
}