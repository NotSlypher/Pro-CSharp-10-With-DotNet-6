using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace LINQApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 1, 2, 4, 9, 15, 23, 45 };
            int[] oddNums = numbers.Where(n => n % 2 == 1).ToArray();

            oddNums = (from n in numbers
                       where n % 2 == 1
                       select n).ToArray();
            Console.WriteLine();*/

            /*var customers = from c in CreateCustomers()
                            where c.Id.EndsWith('o')
                            select c;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }*/

            /*var customers = from c in XDocument.Load("Customers.xml").Descendants("Customers").Descendants()
                            select new Customer
                            {
                                City = c.Attribute("Name").Value,
                                Id = c.Attribute("Id").Value
                            };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.City);
                Console.WriteLine(customer.Id);
            }*/

            /*var customers = XDocument.Load("Customers.xml");
            var customerRam = from c in customers.Descendants("Customers").Descendants()
                              where c.Attribute("Name").Value == "Ram"
                              select c;
            foreach (var cust in customerRam)
            {
                Console.WriteLine(cust);
            }*/

            var dbConnection = Environment.GetEnvironmentVariable("ProductConnectionString", EnvironmentVariableTarget.User);
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
            dbContextOptions.UseSqlServer(dbConnection);

            ApplicationDbContext db = new ApplicationDbContext(dbContextOptions.Options);
            var products = db.Products;
            var productsElectronics = from p in products
                                      group p by p.Category into g
                                      select new
                                      {
                                          Key = g.Key,
                                          Products = g.ToList()
                                      };
            foreach (var productList in productsElectronics)
            {
                foreach (var product in productList.Products)
                {
                    Console.WriteLine(product);
                }
            }

            var productsXML = new XElement("Products",
                from p in db.Products.ToList()
                select new XElement("Product", new XAttribute("Id", p.Id),
                new XElement("Name", p.Name),
                new XElement("Description", p.Description),
                new XElement("Price", p.Price)));
            Console.WriteLine(productsXML);
            productsXML.Save(@"C:\Products.xml");

        }

        /*public static IEnumerable<Customer> CreateCustomers() {
            return new List<Customer>
            {
                new Customer{Id = "ALFKI", City="Berlin"},
                new Customer{Id="BONAP",City="London"},
                new Customer{Id="dsbfo", City="Pune"},
                new Customer{Id="dsdso", City="Pune"},
                new Customer{Id="wfbfo", City="Mumbai"},
                new Customer{Id="wfaso", City="Delhi"},
                new Customer{Id="wfxfbo", City="Noida"},
                new Customer{Id="wfwedo", City="Latur"},
            };
        }*/
    }
}
