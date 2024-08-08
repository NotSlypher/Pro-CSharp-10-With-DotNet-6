using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.AccessData
{
    internal interface IProductDataAcess
    {
        public void UpsertProduct(int? id);
        public void DeleteProduct(int id);
        public void DeleteAll();
        public void ShowProductById(int id);
        public void ShowProductsByCategory();
        public void ShowAllProducts();
    }
}
