using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Entities
{
    public class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }
}
