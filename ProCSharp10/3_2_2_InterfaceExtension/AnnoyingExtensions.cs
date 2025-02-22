using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_2_InterfaceExtension
{
    static class AnnoyingExtensions
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }
}
