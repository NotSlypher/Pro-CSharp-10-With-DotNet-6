using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SimpleException
{
    public class CarIsDeadException: ApplicationException
{
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string cause, DateTime dateTime): this(cause, dateTime, string.Empty) { }
        public CarIsDeadException(string cause, DateTime time, string message) : this(cause, time, message, null)
        {
        }
        public CarIsDeadException(string cause, DateTime time, string message, System.Exception inner)
        : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
