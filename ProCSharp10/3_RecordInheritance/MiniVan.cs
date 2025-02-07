using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RecordInheritance
{
    public sealed record MiniVan :Car

    {
        public int SeatingCapacity { get; init; }
        public MiniVan(string make, string model, string color, int seatingCapacity) : base(make, model, color)
        {
            SeatingCapacity = seatingCapacity;
        }
    }
}
