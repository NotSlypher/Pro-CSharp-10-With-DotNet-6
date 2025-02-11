using System.Collections;

namespace _2_4_5_CustomEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fun with ienumerators");
            Garage carLot = new Garage();

            // hand over each car in the collection?
            foreach (Car c in carLot)
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }

            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            Car myCar = (Car)i.Current;
            Console.WriteLine($"{myCar.PetName} is going {myCar.CurrentSpeed} MPH");
        }
    }
}
