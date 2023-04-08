using Task1.Entities;

foreach (var vehicle in DB.Vehicles)
{
    vehicle.PrintVehicle();
}

Car vehicle1 = new Car
{
    Id = 4,
    Type = "Lada",
    YearOfProduction = 1980,
    FuelTank = 42
};

Vehicle vehicle2 = new Vehicle
{
    Id = 5,
    Type = "",
    YearOfProduction = 0
};

Console.WriteLine($"Vehicle 1 is valid: {Validator.Validate(vehicle1)}");
Console.WriteLine($"Vehicle 2 is valid: {Validator.Validate(vehicle2)}");