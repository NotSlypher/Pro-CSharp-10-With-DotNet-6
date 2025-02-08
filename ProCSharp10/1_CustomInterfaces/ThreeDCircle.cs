using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    public class ThreeDCircle: Circle, IDraw3D
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the 3D Circle", PetName);
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
