// Class: the blueprint / building block
class MyClass
{
    // Method: defines the work/behavior
    public void Hello()
    {
        Console.WriteLine("Hello Everyone!");
    }
}

class ClassObject
{
    public static void Main(string[] args)
    {
        // Create an object of MyClass
        MyClass myClass1 = new MyClass();

        // Call the method on the object
        myClass1.Hello();
    }
}