using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    public class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public Motorcycle() {
            Console.WriteLine("default constructor");
        }
        public Motorcycle(int intensity) : this(intensity, "") {
            Console.WriteLine("intensity constructor");
        }
        public Motorcycle(string name) : this(0, name) {
            Console.WriteLine("string constructor");
        }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("master constructor");
            this.name = name;
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }
    }
}
