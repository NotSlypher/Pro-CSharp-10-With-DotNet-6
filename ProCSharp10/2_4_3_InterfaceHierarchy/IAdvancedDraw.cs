using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_3_InterfaceHierarchy
{
    public interface IAdvancedDraw: IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
        new int TimeToDraw() => 25;
    }
}
