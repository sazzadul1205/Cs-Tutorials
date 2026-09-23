using System;

class Teacher
{
    public string Name;

    public Teacher(string name)
    {
        Name = name;
    }
}

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }

    public void LearnFrom(Teacher teacher)
    {
        Console.WriteLine(Name + " learns from " + teacher.Name);
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("John");
        Student student = new Student("Mike");

        student.LearnFrom(teacher);
    }
}