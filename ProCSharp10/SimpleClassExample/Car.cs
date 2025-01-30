using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    public class Car
    {
        // the 'state' of the Car
        public string petName;
        public int currSpeed;

        public Car() {
            petName = "Fred"; // default name
            currSpeed = 10; // default speed
        } // default constructor

        public Car(string name, int speed)
        {
            petName = name;
            currSpeed = speed;
        } // overloaded constructor

        // Constructor with an out parameter
        public Car(string name, int speed, out bool isSafe)
        {
            petName = name;
            currSpeed = speed;
            isSafe = (currSpeed < 100) ? true : false;
        }

        // the functionality of the Car
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
