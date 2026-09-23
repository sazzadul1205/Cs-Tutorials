class Person
{
    public string? Name;
}

class Student : Person
{
    public int StudentId;
}

class CollegeStudent : Student
{
    public string? CollegeName;
}

class Program
{
    static void Main()
    {
        CollegeStudent student = new CollegeStudent();

        student.Name = "Sazzadul";
        student.StudentId = 1;
        student.CollegeName = "MIT";

        Console.WriteLine(student.Name);
        Console.WriteLine(student.StudentId);
        Console.WriteLine(student.CollegeName);
    }
}