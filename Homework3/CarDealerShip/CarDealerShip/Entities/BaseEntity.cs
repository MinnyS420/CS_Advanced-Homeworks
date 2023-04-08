using CarDealerShip.Entities.Enum;

namespace CarDealerShip.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public TypeFuelEnum FuelType { get; set; }
        public abstract void Drive(string destinationName);
    }
}
