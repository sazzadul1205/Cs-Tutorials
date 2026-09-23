using System;

namespace Name
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Sazzadul", 25);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
