using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id is {Id}\t\t Name is {Name}\t\t Category is {Category}\t\t Description is {Description}\t\t Price is {Price}";
        }
    }
}
