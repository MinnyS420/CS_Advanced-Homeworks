namespace CarDealerShip.Entities
{
    public class AmericanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving {Brand} {Model} to {destinationName}!");
        }
    }
}
