using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_3_ForEachWithExtensionMethods
{
    static class GarageExtensions
    {
        public static IEnumerable GetEnumerator(this Garage g) => g.CarsInGarage.GetEnumerator();
    }
}
