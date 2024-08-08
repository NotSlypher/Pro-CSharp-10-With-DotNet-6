using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    internal class InvalidProductIdException: ApplicationException
    {
        private string niceMessage;

        public InvalidProductIdException(string message)
        {
            niceMessage = message;
        }

        public override string Message => niceMessage;
    }
}
