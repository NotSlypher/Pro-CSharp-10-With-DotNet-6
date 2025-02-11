using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_3_InterfaceHierarchy
{
    public interface IDrawable
    {
        void Draw();
        int TimeToDraw() => 5;
    }
}
