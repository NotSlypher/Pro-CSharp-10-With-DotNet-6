using Microsoft.EntityFrameworkCore;

namespace EFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbConnection = "Data Source=localhost;Initial Catalog=NiceTrainingDB;Integrated Security=True;Trust Server Certificate=True";
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextOptions.UseSqlServer(dbConnection);

            ApplicationDbContext db = new ApplicationDbContext(dbContextOptions.Options);
            var products = db.Products;

            Console.WriteLine("-------------- List of Products ----------");

            foreach (var product in products) {
                Console.WriteLine(product);
            }

            var productsOfCategory = db.Products.Where(p => p.Category == "Stationary");

            Console.WriteLine("-------------- Products of Stationary ----------");

            foreach (var product in productsOfCategory) {
                Console.WriteLine(product);
            }

            

        }
    }
}
