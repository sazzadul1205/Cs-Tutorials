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

class Puppy : Dog
{
    public void Play()
    {
        Console.WriteLine("Playing");
    }
}