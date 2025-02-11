using _2_4_6_CustomEnumeratorWithYield;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("working with custom enumerator with yield");
        Garage carLot = new Garage();
        //try
        //{

        //	IEnumerator carEnumerator = carLot.GetEnumerator();

        //}
        //catch (Exception e)
        //{
        //          Console.WriteLine("Exception thrown on GetEnumerator");
        //}

        foreach (Car c in carLot)
        {
            Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
        }

        Console.WriteLine();

        foreach (Car c in carLot.GetTheCars(true))
        {
            Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
        }

        Console.ReadLine();
    }
}