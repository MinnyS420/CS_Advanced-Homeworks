namespace CarDealerShip.Entities
{
    public class JapaneseCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving {Brand} {Model} to {destinationName}!");
        }
    }
}
