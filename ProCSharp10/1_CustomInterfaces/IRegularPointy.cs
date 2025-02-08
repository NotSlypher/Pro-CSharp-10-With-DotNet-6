using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1_CustomInterfaces
{
    public interface IRegularPointy: IPointy
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;

        //Static members are also allowed in C# 8.0 interfaces
        static string ExampleProperty { get; set; }
        static IRegularPointy() => ExampleProperty = "Example";
    }
}
