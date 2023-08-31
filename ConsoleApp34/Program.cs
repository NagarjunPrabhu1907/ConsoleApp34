using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleClassExample
{
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Method
        public void Introduce()
        {
            Console.WriteLine($"Hello! My name is {Name} and I am {Age} years old.");
        }
        public void Greet(string otherPersonName)
        {
            Console.WriteLine($"Hello, {otherPersonName}! My name is {Name}. Nice to meet you!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // instance of the Person class
            Person person1 = new Person();

            // Set properties 
            person1.Name = "Alice";
            person1.Age = 30;

            // Call the Introduce method
            person1.Introduce();

            person1.Greet("Bob");
        }
    }
}

