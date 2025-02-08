using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    public class Square: Shape, IRegularPointy
    {
        public Square() { }
        public Square(string name) : base(name) { }
        //Draw comes from the shape base class
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Square", PetName);
        }

        //this comes from iPointy interface
        public byte Points => 4;

        //These comes from IRegularPointy
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        //note perimeter property is not implemented
    }
}

