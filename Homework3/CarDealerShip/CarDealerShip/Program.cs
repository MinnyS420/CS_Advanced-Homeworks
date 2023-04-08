using CarDealerShip.Entities;
using CarDealerShip.Entities.Enum;

GenericDb<BaseEntity> db = new GenericDb<BaseEntity>();

JapaneseCar toyota = new JapaneseCar
{
    Id = 1,
    Brand = "Toyota",
    Model = "Corolla",
    MaxSpeed = 180,
    HorsePower = 120,
    FuelType = TypeFuelEnum.Gass
};

GermanCar Opel = new GermanCar
{
    Id = 2,
    Brand = "Opel",
    Model = "Kapitan",
    MaxSpeed = 120,
    HorsePower = 80,
    FuelType = TypeFuelEnum.Gass
};

FrenchCar Peugeot_404  = new FrenchCar
{
    Id = 3,
    Brand = "Peugeot 404",
    Model = "Cabriolet",
    MaxSpeed = 190,
    HorsePower = 90,
    FuelType = TypeFuelEnum.Diesel
};

AmericanCar Plymouth_Barracuda = new AmericanCar
{
    Id= 4,
    Brand = "Plymouth Barracuda",
    Model = "Formula S",
    MaxSpeed = 350,
    HorsePower = 200,
    FuelType = TypeFuelEnum.Gass
};

db.Insert(Opel);
db.Insert(toyota);
db.Insert(Peugeot_404);
db.Insert(Plymouth_Barracuda);

BaseEntity car = db.GetById(1);
BaseEntity car2 = db.GetById(2);
BaseEntity car3 = db.GetById(3);
BaseEntity car4 = db.GetById(4);

Console.WriteLine("==============================================================");
Console.WriteLine("All cars:");
Console.ForegroundColor = ConsoleColor.Green;
db.PrintAll();

Console.ResetColor();
Console.WriteLine("==============================================================");
string text = $"And we have a winner of {car.Brand} {car.Model} car!!!";
text.Color(ConsoleColor.Red);
string text2 = $"And we have a winner of {car2.Brand} {car2.Model} car!!!";
text2.Color(ConsoleColor.Green);
string text3 = $"And we have a winner of {car3.Brand} {car3.Model} car!!!";
text3.Color(ConsoleColor.Blue);
string text4 = $"And we have a winner of {car4.Brand} {car4.Model} car!!!";
text4.Color(ConsoleColor.Cyan);

Console.ResetColor();
Console.WriteLine("==============================================================");
Plymouth_Barracuda.Drive("Oghrid");
Peugeot_404.Drive("Skopje");
toyota.Drive("Kumanovo");
Opel.Drive("Skopje");
                                                            // cisto da izgleda po cisto da ne stojat toa informaciite dole xD
Console.ReadLine();               