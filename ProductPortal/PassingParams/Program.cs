

namespace PassingParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 1;
            //var b = 2;

            //Console.WriteLine($"before calling method a = {a}, b = {b}");

            //PassByValue(a, out b);
            ////PassByReference(ref a, ref b);
            //Console.WriteLine($"after calling method a = {a}, b = {b}");

            AddNums(32,32,43,12,342);

        }

        private static void AddNums(params int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result += num;
            }
            Console.WriteLine($"Addition of nums is {result}");
        }

        private static void PassByValue(int a, out int b)
        {
            Console.WriteLine($"in method before change a = {a}");
            a += 3;
            b = 4;
            Console.WriteLine($"in method after change a = {a}, b = {b}");

        }

        private static void PassByReference(ref int a, ref int b)
        {
            Console.WriteLine($"in method before change a = {a}, b = {b}");
            a += 3;
            b += 4;
            Console.WriteLine($"in method after change a = {a}, b = {b}");

        }
    }
}
