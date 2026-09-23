using System;

namespace Name
{
    class Person
    {
        public string? Name;
        public int Age;

        public void Hello()
        {
            Console.WriteLine($"Hello {Name} and my age is {Age}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Sazzadul";
            person.Age = 21;

            person.Hello();
        }
    }
}
