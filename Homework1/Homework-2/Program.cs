// Create some vehicles
using Homework_2.Entities;

Car car = new Car();
Truck truck = new Truck();

// Create an instance of CarCenter
CarCenter carCenter = new CarCenter();

// Call methods to test functionality
carCenter.WashCar(car);
carCenter.WashTruck(truck);
carCenter.PumpGas(car);
carCenter.PumpGas(truck);
carCenter.CheckVehicle(car);
carCenter.CheckVehicle(truck);
carCenter.FixVehicle(car);
carCenter.FixVehicle(truck);