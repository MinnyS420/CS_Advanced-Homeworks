using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Entities.Interfaces
{
    public interface ICat : IAnimal
    {
        void Eat(string food);
    }

}
