using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    public class Triangle: Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }

        //public byte Points { get { return 3; } } 
        public byte Points => 3;

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }
    }
}
