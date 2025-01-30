using SimpleClassExample;

Motorcycle c = new Motorcycle(5);
Console.WriteLine($"{c.driverIntensity}");

Console.WriteLine("Car class");
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

for(int i = 0; i < 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
