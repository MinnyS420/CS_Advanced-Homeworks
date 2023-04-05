using Homework_2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash carWash;
        private GasPump gasPump;
        private RepairService repairService;

        public CarCenter()
        {
            carWash = new CarWash();
            gasPump = new GasPump();
            repairService = new RepairService();
        }

        public void WashCar(Car car)
        {
            carWash.WashCar(car);
        }

        public void WashTruck(Truck truck)
        {
            carWash.WashTruck(truck);
        }

        public void PumpGas(Vehicle vehicle)
        {
            gasPump.PumpGas(vehicle);
        }

        public void CheckVehicle(Vehicle vehicle)
        {
            repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            repairService.FixVehicle(vehicle);
        }
    }
}
