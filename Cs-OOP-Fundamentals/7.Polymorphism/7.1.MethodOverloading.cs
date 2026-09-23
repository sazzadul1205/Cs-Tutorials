using System;

class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        calculator.Add(10, 20);
        calculator.Add(10, 20, 30);
    }
}