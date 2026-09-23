using System;

class Teacher
{
    public string Name;

    public Teacher(string name)
    {
        Name = name;
    }
}

class School
{
    public string Name;
    public Teacher Teacher;

    public School(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
    }

    public void ShowTeacher()
    {
        Console.WriteLine(Name + " has teacher " + Teacher.Name);
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("John");

        School school = new School("ABC School", teacher);

        school.ShowTeacher();
    }
}