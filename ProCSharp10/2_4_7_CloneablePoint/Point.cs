using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_7_CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
            this.desc.PetName = name;
        }
        public Point() {}
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName}; \nID = {desc.PointID}\n";

        // Return a copy of the current object
        //public object Clone() => new Point(this.X, this.Y);
        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}