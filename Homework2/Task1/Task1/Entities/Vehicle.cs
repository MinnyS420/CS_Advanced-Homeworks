namespace Task1.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public int YearOfProduction { get; set; }
        public string? BatchNumber { get; set; } 

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"This vehicle ID is:{Id}\nType:{Type}\nOn this vehicle the year of production is {YearOfProduction}!");
        }
    }
}
