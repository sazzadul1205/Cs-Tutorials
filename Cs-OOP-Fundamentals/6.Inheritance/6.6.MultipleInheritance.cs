class Person
{
    public string? Name;
}

interface IStudent
{
    void Study();
}

interface IWorker
{
    void Work();
}

class Student : Person, IStudent, IWorker
{
    public void Study()
    {
        Console.WriteLine("Studying");
    }

    public void Work()
    {
        Console.WriteLine("Working");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Sazzadul";

        student.Study();
        student.Work();

        Console.WriteLine(student.Name);
    }
}