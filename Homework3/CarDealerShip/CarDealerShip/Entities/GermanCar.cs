namespace CarDealerShip.Entities
{
    public class GermanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving {Brand} {Model} to {destinationName}!");
        }
    }
}
