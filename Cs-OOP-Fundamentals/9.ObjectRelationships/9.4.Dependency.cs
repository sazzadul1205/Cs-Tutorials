using System;

class Printer
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}

class Report
{
    public void Generate(Printer printer)
    {
        printer.Print("Report generated");
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        Report report = new Report();

        report.Generate(printer);
    }
}