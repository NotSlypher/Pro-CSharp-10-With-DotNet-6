using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_1_SimpleGC
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public override string ToString() => $"{PetName} is going {CurrentSpeed} MPH";
    }
}
