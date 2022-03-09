using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mulththreading
{
    internal class Program
    {
        public static void Main()
        {
            Thread ThreadObject1 = new Thread(Example1); //Creating the Thread    
            Thread ThreadObject2 = new Thread(Example2);
            ThreadObject1.Start(); //Starting the Thread    
            ThreadObject2.Start();
        }
        static void Example1()
        {
            Console.WriteLine("Thread1 Started");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread1 Executing");
                Thread.Sleep(5000); //Sleep is used to pause a thread and 5000 is MilliSeconds that means 5 Seconds    
            }
        }
        static void Example2()
        {
            Console.WriteLine("Thread2 Started");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread2 Executing");
                Thread.Sleep(5000);
            }
        }
    }
}
