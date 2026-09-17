// Class: Blueprint
class MyClass
{
    public string Name;

    // Constructor :Runs when a Object is First Created 
    public MyClass(string name)
    {
        Name = name;
    }

    public void Hello()
    {
        Console.WriteLine("Hello " + Name);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Create object and give it data
        MyClass myClass1 = new MyClass("Pritom");

        myClass1.Hello();
    }
}