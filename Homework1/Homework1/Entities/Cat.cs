using Homework1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"I am a cat named {Name} and I am {Age} years old.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I am eating {food}.");
        }
    }
}
