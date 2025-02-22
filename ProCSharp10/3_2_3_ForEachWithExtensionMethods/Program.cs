using _3_2_3_ForEachWithExtensionMethods;

Garage newGarage = new Garage();

foreach(Car car in newGarage)
{
    Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
}