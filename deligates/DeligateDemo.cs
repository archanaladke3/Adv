using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.deligates
{
    public delegate void mydel();/* delgete is an object  refernace*/
    class DeligateDemo
    {
         public  static void greet() 
        {
            Console.WriteLine("good morning");
        }
        public static void Main(string[] args)
        {
            //single cast;
            mydel d = greet;
            d();
        }
    }

    public delegate void mydel1( int a, int b);
    public class DeligateDemo2
    {
        public static void m1(int a, int c)
        {
            Console.WriteLine("Addition:"+(a+c) );
           
        }
        public static void sb(int a, int b)
        {
            Console.WriteLine("sqr:"+a*b);
           
        }
        public static void Main(string[] args)
        {
            mydel1 d2 = sb;
            //multicast:holding more than one refernce
            d2 = d2 + m1;
            d2(9 ,8);

        }
    }
}
