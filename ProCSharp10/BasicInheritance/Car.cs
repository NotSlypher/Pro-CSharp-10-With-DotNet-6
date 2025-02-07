using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Car
    {
        public readonly int maxSpeed;
        private int _currSpeed;
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if (_currSpeed > maxSpeed)
                {
                    _currSpeed = maxSpeed;
                }
            }
        }
    }
}
