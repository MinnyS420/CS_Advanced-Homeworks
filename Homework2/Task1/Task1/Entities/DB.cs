using Task1.Entities;

public static class DB
{
    public static List<Vehicle> Vehicles { get; set; }

    static DB()
    {
        Vehicles = new List<Vehicle>
        {
            new Car
            {
                Id = 1,
                Type = "Sedan",
                YearOfProduction = 2020,
                BatchNumber = "001",
                FuelTank = 50,
                CountriesProduced = new List<string>(new[] {"USA", "Canada"}) },
            new Bike
            {
                Id = 2,
                Type = "Mountain Bike",
                YearOfProduction = 2018,
                BatchNumber = "002",
                Color = "Red"
            },
            new Vehicle
            {
                Id = 3,
                Type = "Jugo Coral 1.1",
                YearOfProduction = 1992,
                BatchNumber = "003"
            },
            new Car
            { Id = 4,
                Type = "Stojadin(kecko)",
                YearOfProduction = 1971,
                BatchNumber = "004",
                FuelTank = 60,
                CountriesProduced = new List<string>(new[] {"Srbija","Macedonia"})
            }
        };
    }
}
