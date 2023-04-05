using Homework_2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("Washing a car");
        }

        public void WashTruck(Truck truck)
        {
            Console.WriteLine("Washing a truck");
        }
    }
}
