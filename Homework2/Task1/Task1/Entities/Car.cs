namespace Task1.Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesProduced { get; set; } = new List<string>();
        public override void PrintVehicle()
        {
            Console.Write($"Type: {Type},\nCountries Produced:\n");
            for (int i = 0; i < CountriesProduced.Count; i++)
            {
                Console.Write(CountriesProduced[i]);
                if (i < CountriesProduced.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
