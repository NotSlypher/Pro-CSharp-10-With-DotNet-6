using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    delegate void CalcDelegate(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            /*NiceCalculator niceCalculator = new NiceCalculator();
            CalcDelegate calc = new CalcDelegate(niceCalculator.Add);

            calc += niceCalculator.Difference;
            calc += niceCalculator.Product;

            calc?.Invoke(12,23);

            Console.WriteLine();

            calc -= niceCalculator.Difference;
            calc.Invoke(21, 32);*/

            DoorBell doorBell = new DoorBell();
            doorBell.Pressed += DoorOpening;        //event subscriber

            doorBell.RingBell("Ayush");
        }

        //Event handler
        static void DoorOpening(string uName)
        {
            Console.WriteLine($"HI {uName}, welcome to our home");
        }
    }
}
