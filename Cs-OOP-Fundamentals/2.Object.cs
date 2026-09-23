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
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = "Sazzadul";
            person1.Age = 21;

            
            person2.Name = "Mohammed";
            person2.Age = 55;

            
            person3.Name = "Jon";
            person3.Age = 2;

            person1.Hello();
            person2.Hello();
            person3.Hello();
        }
    }
}
