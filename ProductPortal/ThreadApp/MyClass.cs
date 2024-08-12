using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadApp
{

    public class MyClass
    {
        private object threadLock = new object();
        public void MyMethod()
        {
            Monitor.Enter(threadLock);
            try
            {
                Console.WriteLine("my method is running on" + Thread.CurrentThread.ManagedThreadId);
                Thread current = Thread.CurrentThread;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + " by thread " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(threadLock);
            }
        }
    }
}
