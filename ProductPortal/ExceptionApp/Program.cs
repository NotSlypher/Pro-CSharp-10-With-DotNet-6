namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("understand exceptions");
            Console.WriteLine("enter num 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2");
            int n2 = int.Parse(Console.ReadLine());
            try
            {
                var result = n1 / n2;
                Console.WriteLine($"division of n1 by n2 is {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"sorry cannot divide by zero!! system message: {e.Message}");
            }
        }
    }
}
