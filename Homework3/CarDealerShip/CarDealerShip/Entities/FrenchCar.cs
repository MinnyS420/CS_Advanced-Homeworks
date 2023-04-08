namespace CarDealerShip.Entities
{
    public class FrenchCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving {Brand} {Model} to {destinationName}!");
        }
    }
}
