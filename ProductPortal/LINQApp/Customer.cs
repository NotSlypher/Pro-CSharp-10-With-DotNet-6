using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    public class Customer
    {
        
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id is: {Id}\t CIty is: {Name}";
        }
    }
}
