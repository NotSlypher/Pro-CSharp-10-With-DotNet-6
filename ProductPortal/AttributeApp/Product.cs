using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeApp
{
    [ProductDescription(Description = "Electronics Products")]
    public class Product
    {
        [Obsolete("Not available for you")]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
