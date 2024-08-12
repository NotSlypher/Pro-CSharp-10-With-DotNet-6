using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace ThreadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task<int> t1 = new Task<int>(GenerateNumbers);
            //Task<string> t2 = new Task<string>(printChar);
            //Task<int> t3 = new Task<int>(PrintArray);

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //Console.WriteLine($"Numbers generated till {t1.Result}");
            //Console.WriteLine($"original string is {t2.Result}");
            //Console.WriteLine($"Array count is {t3.Result}");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"First for loop on thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            sw.Stop();

            sw.Restart();
            

            Parallel.For(0, 6, i =>
            {
                Console.WriteLine($"Second for loop on thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            });
            sw.Stop();
        }

        static int GenerateNumbers()
        {
            Console.WriteLine($"Generate threads is running on - {Thread.CurrentThread.ManagedThreadId}");
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 - number: {i}");
                Thread.Sleep(1000);
            }
            return i;
        }

        static string printChar()
        {
            Console.WriteLine($"Generate threads is running on - {Thread.CurrentThread.ManagedThreadId}");
            string str = "Hello, I am Ayush!";
            foreach (var s in str)
            {
                Console.WriteLine($"Method2 - Character: {s}");
                Thread.Sleep(1000);
            }
            return str;
        }

        static int PrintArray()
        {
            Console.WriteLine($"Generate threads is running on - {Thread.CurrentThread.ManagedThreadId}");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var s in arr)
            {
                Console.WriteLine($"Method 3 - Array : {s}"); ;
            }
            return arr.Length;
        }
    }
}
