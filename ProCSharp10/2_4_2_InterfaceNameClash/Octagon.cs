using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2_InterfaceNameClash
{
    public class Octagon: IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    Console.WriteLine("Drawing the Octagon...");
        //}
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing the Octagon to printer.");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing the Octagon to memory.");
        }
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing the Octagon to form.");
        }
    }
}
