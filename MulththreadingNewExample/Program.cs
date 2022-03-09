using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulththreadingNewExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           // await ExecuteAsyncFunctions();
            Console.WriteLine();

            Multithreading multithreading = new Multithreading();
            multithreading.ExecuteMultithreading();
            Console.ReadKey();
        }
    }
    public class Multithreading
    {
        public void FirstMethod()
        {
            Console.WriteLine("First Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("First Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("Second Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public void ThirdMethod()
        {
            Console.WriteLine("Third Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("Third Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public void ExecuteMultithreading()
        {
            Thread t1 = new Thread(new ThreadStart(FirstMethod));
            Thread t2 = new Thread(new ThreadStart(SecondMethod));
            Thread t3 = new Thread(new ThreadStart(ThirdMethod));
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }


}
