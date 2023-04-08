using Task1.Entities;

public static class Validator
{
    public static bool Validate(Vehicle vehicle)
    {
        return vehicle.Id != 0 && !string.IsNullOrEmpty(vehicle.Type) && vehicle.YearOfProduction != 0;
    }
}
