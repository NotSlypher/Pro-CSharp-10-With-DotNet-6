using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    public abstract class ClonableType
    {
        // Only derived classes can access this method.
        // Classes in other hierarchies cannot access this method.
        public abstract object Clone();
    }
}
