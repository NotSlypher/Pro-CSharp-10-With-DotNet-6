using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_AutoProps
{
    public class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void Details()
        {
            Console.WriteLine($"Name is {PetName} with speed {Speed} and color {Color}");
        }
    }
}
