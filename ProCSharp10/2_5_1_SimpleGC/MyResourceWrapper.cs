using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_1_SimpleGC
{
    class MyResourceWrapper
    {
        // Clean up unmanaged resources here. // Beep when destroyed (testing purposes only!)
        ~MyResourceWrapper() => Console.Beep();
    }
}
