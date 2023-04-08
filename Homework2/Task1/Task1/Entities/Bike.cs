namespace Task1.Entities
{

    public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;

        public override void PrintVehicle()
        {
            Console.WriteLine($"This {Type} is producted in {YearOfProduction} year and its collored {Color}.");
        }
    }
}

