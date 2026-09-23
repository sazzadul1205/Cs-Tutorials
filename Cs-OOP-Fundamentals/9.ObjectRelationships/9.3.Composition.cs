using System;

class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

class Car
{
    private Engine engine;

    public Car()
    {
        engine = new Engine();
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car started");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        car.StartCar();
    }
}