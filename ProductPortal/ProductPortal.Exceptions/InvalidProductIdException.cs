using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Exceptions
{
    public class InvalidProductIdException : Exception
    {
        public override string Message => "Invalid Product Id";
    }
}
