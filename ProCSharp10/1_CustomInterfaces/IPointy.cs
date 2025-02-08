using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    // This interface defines the behavior of "having points"
    public interface IPointy
    {
        //implicitly public and abstract
        //byte GetNumberOfPoints();

        // a read-write property in an interface would look like this:
        //int Points { get; set; }

        // while a read-only property in an interface would look like this:
        byte Points { get; }
    }
}
