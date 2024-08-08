using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public delegate void Bell(string user); 
    public class DoorBell
    {
        //actual event that get raised
        public event Bell? Pressed;
        public void RingBell(string user)
        {
            Pressed?.Invoke(user);
        }
    }
}
