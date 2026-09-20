class MyClass
{
    // Private property: Only accessible inside this class not outside   
    private string name;

    // Public property
    // This si declared to access the Private Property 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Method: Defines the Action of the class
    public void Hi()
    {
        Console.WriteLine($"Hello My Name is {Name}");
    }
}

class Fields
{

    public static void Main(string[] args)
    {
        MyClass myClass1 = new MyClass();
        MyClass myClass2 = new MyClass();

        myClass1.Name = "Pritom";


        myClass2.Name = "Sazzadul";

        myClass1.Hi();
        myClass2.Hi();
    }

}