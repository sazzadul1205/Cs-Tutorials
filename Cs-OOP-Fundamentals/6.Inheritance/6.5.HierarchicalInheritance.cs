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

class Teacher : Person
{
    public string? Subject;
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Sazzadul";
        student.StudentId = 1;

        student.SayHello();

        Console.WriteLine(student.Name);
        Console.WriteLine(student.StudentId);

        Teacher teacher = new Teacher();

        teacher.Name = "Mohammed";
        teacher.Subject = "CSE";

        teacher.SayHello();

        Console.WriteLine(teacher.Name);
        Console.WriteLine(teacher.Subject);
    }
}