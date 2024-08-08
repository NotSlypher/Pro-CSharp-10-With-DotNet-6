namespace DelegateApp
{
    public class NiceCalculator
    {
        public void Add(int a, int b) => Console.WriteLine($"Sum is {a + b}");
        public void Difference(int a, int b) => Console.WriteLine($"Difference is {a - b}");
        public void Product(int a, int b) => Console.WriteLine($"Product is {a * b}");
    }
}
