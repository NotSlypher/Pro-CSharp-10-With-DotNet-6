/*
    Add product new product
        id, name, category, description and price
 */

using Microsoft.EntityFrameworkCore;
using ProductPortal.AccessData;
using ProductPortal.DataAccess;
using ProductPortal.Model;
using System.Diagnostics;
using System.Xml.Linq;

namespace ProductPortal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Class less 
            int id;
            string name;
            string category;
            string description;
            int price;

            Console.WriteLine("Enter product id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter product catergory: ");
            category = Console.ReadLine();

            Console.WriteLine("Enter product descripttion: ");
            description = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The product id is: " + id +
                "\n The product name is: " + name +
                "\n The product category is: " + category +
                "\n The product description is: " + description +
                "\n The product price is: " + price
                );
            */

            var DbConnection = Environment.GetEnvironmentVariable("ProductConnectionString", EnvironmentVariableTarget.User);
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextOptions.UseSqlServer(DbConnection);

            ApplicationDbContext db = new ApplicationDbContext(dbContextOptions.Options);

            ProductDataAccess productDataAccess = new ProductDataAccess(db);
            bool done = false;
            do
            {
                try
                {
                    Console.WriteLine("\n\n*******************NICE Product Portal******************\n\n" +
                    "Select option from menu\n\n" +
                    "Menu\n" +
                    "1. Create Product\t\t2. Update by Id\t\t3. View by Id\t\t4. View by Category\t\t5. View All\t\t6. Delete by Id\t\t7.Delete All\t\t\n8.Exit\n\n" +
                    "**********************************************************"
                    );
                    int option = 0, id = 0;
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (option)
                    {
                        case 1:
                            productDataAccess.UpsertProduct(null);
                            break;
                        case 2:
                            Console.WriteLine("Insert product id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            productDataAccess.UpsertProduct(id);
                            break;
                        case 3:
                            Console.WriteLine("Insert product id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            productDataAccess.ShowProductById(id);
                            break;
                        case 4:
                            productDataAccess.ShowProductsByCategory();
                            break;
                        case 5:
                            productDataAccess.ShowAllProducts();
                            break;
                        case 6:
                            Console.WriteLine("Insert product id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            productDataAccess.DeleteProduct(id);
                            break;
                        case 7:
                            productDataAccess.DeleteAll();
                            break;
                        case 8:
                            done = true;
                            break;
                        default:
                            Console.WriteLine("########## Wrong option selected ###########");
                            break;


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n" +
                        $"\t{e.Message}" +
                        $"\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n\n");
                }
            }
            while (!done);

            Console.WriteLine("~~~~~~~~~~Program Exited~~~~~~~~~");

        }

        private static void DeleteProduct(Product product)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" +
                "\n\n\t\t\t Product Deleted\n\n" +
                "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            product.Id = 0;
            product.Price = 0;
            product.Name = "";
            product.Description = "";
            product.Category = "";
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private static void GetProductDetails(Product product)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~This is Get product page~~~~~~~~~~~~~~~");
            if (product.Id == 0)
            {
                Console.WriteLine("\n\n\t\tNo product to show");
            }
            else
            {
                Console.WriteLine($"The product id is: {product.Id} " +
                                $"\nThe product name is: {product.Name}" +
                                $"\nThe product category is: {product.Category}" +
                                $"\nThe product description is: {product.Description}" +
                                $"\nThe product price is: {product.Price}"
                                );
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}