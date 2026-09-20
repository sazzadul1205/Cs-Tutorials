class MyClass
{
    // Properties: Store and Control the data  
    public string Name {get; set;}
    public int Age {get; set;}
    // Get -> Allows to read the data
    // Set -> Allows to Write the data 

    // Method: Defines the Action of the class
    public void Hi()
    {
        Console.WriteLine($"Hello My Name is {Name} and i am {Age} Years Old ");
    }
}

class Fields
{

    public static void Main(string[] args)
    {
        MyClass myClass1 = new MyClass();
        MyClass myClass2 = new MyClass();

        myClass1.Name = "Pritom";
        myClass1.Age = 25;


        myClass2.Name = "Sazzadul";
        myClass2.Age = 30;

        myClass1.Hi();
        myClass2.Hi();
    }

}