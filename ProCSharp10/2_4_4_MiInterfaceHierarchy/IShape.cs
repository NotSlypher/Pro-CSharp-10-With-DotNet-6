using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_4_MiInterfaceHierarchy
{
    public interface IShape: IDrawablej, IPrintable
    {
        int GetNumberOfSides();
    }
}
