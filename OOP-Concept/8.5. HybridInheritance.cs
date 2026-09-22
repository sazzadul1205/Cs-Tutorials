class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}

interface IPet
{
    void Play();
}

class Puppy : Dog, IPet
{
    public void Play()
    {
        Console.WriteLine("Playing");
    }
}