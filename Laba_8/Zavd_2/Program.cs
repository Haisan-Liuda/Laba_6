using Zavd_2.Models;
using System;

namespace Zavd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

            Console.ReadKey();
        }
    }
}