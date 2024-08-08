using ProductPortal.DataAccess;
using ProductPortal.Exceptions;
using ProductPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.AccessData
{
    public class ProductDataAccess : IProductDataAcess 
    {
        private readonly ApplicationDbContext _db;
        public ProductDataAccess(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public void DeleteAll()
        {
            if (_db.Products.Count() > 0)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" +
                        $"\n\n\t\t\t All Products Deleted\n\n" +
                        "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                _db.Products.RemoveRange(_db.Products);
                _db.SaveChanges();
            }
            else {
                throw new NoProductsException();
            }
        }

        public void DeleteProduct(int id)
        {
            Product? product = _db.Products.FirstOrDefault(p => p.Id ==id);
            if (product == null)
            {
                throw new InvalidProductIdException();
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" +
                    $"\n\n\t\t\t Product Deleted at id {id}\n\n" +
                    "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                _db.Products.Remove(_db.Products.FirstOrDefault(p => p.Id == id));
                _db.SaveChanges();
            }
        }

        public void ShowAllProducts()
        {
            if(_db.Products.Count() <= 0)
            {
                throw new NoProductsException();
            }
            var products = _db.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"\n~~~~~~~~~~~~~~~~Product of id: {product.Id}~~~~~~~~~~~~~~~");
                Console.WriteLine(product);
            }
        }

        public void ShowProductById(int id)
        {
            Product? product = _db.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                throw new InvalidProductIdException();
            }
            Product product = _db.Products.FirstOrDefault(p => p.Id ==id);
            Console.WriteLine($"~~~~~~~~~~~~~~~~Product of id: {id}~~~~~~~~~~~~~~~");
            Console.WriteLine(product);
        }

        public void ShowProductsByCategory()
        {
            Console.WriteLine("~~~~~~~~~~~~~Enter Category to view Products by category~~~~~~~~~~~~");
            Console.Write("Category: ");
            string category = Console.ReadLine();
            List<Product>? products = _db.Products.Where(x => x.Category == category).ToList();
            
            if (products == null)
            {
                Console.WriteLine("XXXXXXXXXXXXXXX No Category found XXXXXXXXXXXXXX");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~Product of id: {product.Id}~~~~~~~~~~~~~~~");
                    Console.WriteLine(product);
                }
            }
        }

        public void UpsertProduct(int? id)
        {
            Product? product;
            if (id == null)
            {
                product = new Product();
                Console.WriteLine("~~~~~~~~~~~~~~~~This is Add product page~~~~~~~~~~~~~~~");
            }
            else
            {
                product = _db.Products.FirstOrDefault(p => p.Id == id);
                if (product == null)
                {
                    throw new InvalidProductIdException();
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~This is Update product page~~~~~~~~~~~~~~~");

            }

            Console.Write("Enter product name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter product category: ");
            product.Category = Console.ReadLine();

            Console.Write("Enter product descripttion: ");
            product.Description = Console.ReadLine();

            Console.Write("Enter product price: ");
            product.Price = Convert.ToInt32(Console.ReadLine());

            if(id == null){
                Console.WriteLine("\n\n\t\tProduct Created successfully");
                _db.Products.Add(product);
            }
            else 
                Console.WriteLine($"\n\n\t\tProduct {id} Updated successfully");
            _db.SaveChanges();
        }
    }
}
