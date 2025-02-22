static void BuildAnonymousType( string make, string color, int currSp)
{
    var car = new { Make = make, Color = color, Speed = currSp };
    Console.WriteLine($"You have a {car.Color} {car.Make} going {car.Speed} MPH");
}