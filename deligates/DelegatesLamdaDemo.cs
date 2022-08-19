using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.deligates
{

    public delegate void mydele (int a, int b);
    class DelegatesLamdaDemo
    {
        // ananmous
        mydele dd = delegate (int a, int b)
        {
            Console.WriteLine("product:" + (a * b));
        };
        
    }




    public delegate void del(int a, int b);
    class LamdaDemo
    {
        public static void Main(string[] args)
        {
            del d = (a, b) => Console.WriteLine("sum:" + (a + b));
            d(12, 56);

        }
    }


    public delegate void mydeleg(int a);
    class LamdaDemo2
    {
        public static void Main(string[] args)
        {
            mydeleg m= (a) =>
            {
                int fact = 1;
                for(int i = 0; i < a; i++)
                {
                    fact = fact * i;

                }
                Console.WriteLine(fact);
              
               
            };
            m(78);

        }
    }
}
