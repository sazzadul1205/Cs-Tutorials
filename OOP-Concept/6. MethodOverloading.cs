
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class MethodOverloading
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        int calc1 = calc.Add(5, 6);
        int calc2 = calc.Add(5, 6, 7);
        double calc3 = calc.Add(5.3, 6.5);

        Console.WriteLine(calc1);
        Console.WriteLine(calc2);
        Console.WriteLine(calc3);
    }
}