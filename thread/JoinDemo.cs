using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adv.thread
{
    class JoinDemo
    {
        static  void m1()
        {
            for(int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000);
            }
           
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("main method");
            Thread t = new Thread(m1);
            t.Join();
            for(int i = 200; i <= 200; i = +2)
            {
                Console.WriteLine("Main" + i);
            }


        }
    }


    class Program
    {
        public static void m1()
        {
            for(int i = 1; i <= 30; i++)
            {
                Console.WriteLine("odd" + i + Thread.CurrentThread.Name);
            }
        }
        public static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            Thread t1 = new Thread(m1);
            t1.Name = "ARchna";
            Console.WriteLine("priority=" + t1.Priority);
            Console.WriteLine("priority=" + t1.Priority);
            Thread t2 = new Thread(m1);
            t2.Name = "abc";
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();


        }
    }
}
