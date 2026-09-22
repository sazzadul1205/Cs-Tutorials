interface IAnimal
{
    void Eat();
}

interface IPet
{
    void Play();
}

class Dog : IAnimal, IPet
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Play()
    {
        Console.WriteLine("Playing");
    }
}