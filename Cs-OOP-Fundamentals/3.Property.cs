using System;

namespace Name
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Sazzadul";
            person.Age = 20;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
