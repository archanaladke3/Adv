using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Adv.thread
{
    class ThreadDemo
    {
        public void m1()
        {
            for(int i = 0; i<= 100; i++)
            {
                Console.WriteLine(i);

            }
        }
        public static void m2()
        {
            Console.WriteLine("m2 method");        
        }
        public static void Main()
        {
            ThreadDemo t = new ThreadDemo();

            Thread t1 = new Thread(t.m1);
            t1.Start();
            Thread t2 = new Thread(m2);
            t2.Start();
            t1.Start();
           
            
            Console.WriteLine("main thread");
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("gm");
            }
            Console.WriteLine("main thread ends");
        }
    }
}
