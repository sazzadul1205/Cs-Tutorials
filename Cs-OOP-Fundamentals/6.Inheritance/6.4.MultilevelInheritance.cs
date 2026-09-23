class Person
{
    public string Name;
}

class Student : Person
{
    public int StudentId;
}

class CollegeStudent : Student
{
    public string CollegeName;
}

class Program
{
    static void Main()
    {
        CollegeStudent student = new CollegeStudent();

        student.Name = "John";
        student.StudentId = 101;
        student.CollegeName = "ABC College";

        Console.WriteLine(student.Name);
        Console.WriteLine(student.StudentId);
        Console.WriteLine(student.CollegeName);
    }
}