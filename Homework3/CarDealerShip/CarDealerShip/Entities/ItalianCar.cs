namespace CarDealerShip.Entities
{
    public class ItalianCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving {Brand} {Model} to {destinationName}!");
        }
    }
}
