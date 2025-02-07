using _1_SimpleException;
using System.Net.Quic;

Console.WriteLine("Creating a car and stepping on it");
Car myCar = new Car("Zippy", 20);
myCar.CrankTunes(true); 
try
{
	for (int i = 0; i < 10; i++)
	{
		myCar.Accelerate(10);
	}
}
catch (Exception e)
{
    Console.WriteLine("\n***Error***");
    Console.WriteLine($"Member name: {0}, e.TargetSite");
}
