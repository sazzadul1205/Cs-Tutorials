using System;

static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        int result1 = Calculator.Add(10, 20);
        int result2 = Calculator.Multiply(5, 4);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}