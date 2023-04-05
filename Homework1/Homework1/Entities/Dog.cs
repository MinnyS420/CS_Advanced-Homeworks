using Homework1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"I am a dog named {Name} and I am {Age} years old.");
        }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
