using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeApp
{
    public class ProductDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public ProductDescriptionAttribute()
        {
            
        }

        public ProductDescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }
}
