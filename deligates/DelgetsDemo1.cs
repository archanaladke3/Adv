using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.deligates
{
    class DelgetsDemo1
    {
        public static double m1(int r, char c)
        {
            Console.WriteLine("m1 method");
            return r * 3.4;

        }
        public static void m2(byte a, string e)
        {
            Console.WriteLine("in m2: " + " "+e + " "+ a);
        }
         public static bool m3(long m)
        {
            Console.WriteLine(" m3");
            return true;
           
        }
        public static void Main(string[] args)
        {
            Func<int,char, double> val = m1;
            double d= m1(12, 'd');
            Console.WriteLine(d);


            Action<byte, string> val2 = m2;
            val2(12, "Archana");

           /*func<long > val3 = m3;
            bool b1 = m3(14555666262);*/
                                        
            Predicate<long> val4 = m3;
            Boolean b = m3(12344);
        }
    }

    class DelgetsDemo2
    {
         public static void m1( int a, int b)
        {
            Console.WriteLine("Addition:" + (a + b));
        }
        public static void m2(string msg)
        {
            Console.WriteLine("msg " + msg);
        }
        public static int cube(int x)
        {
            return x * x * x;
        }
        public static float area(int r)
        {
            return r * r * 3.14f;
        }
        public static  bool isEven(int x)
        {
            return x % 2 == 0;
        }
        public static void Main(string[] args)
        {
            Action<int, int> val = m1;
            val(12, 56);

            Action<string> val2 = m2;
            val2("hey");

            Func<int, int> val3 = cube;
            int d = val3(4);
            Console.WriteLine(d);

            Predicate< int> val4 = isEven;
              bool b=val4(100);
            Console.WriteLine(b);

            Func<int,float> val5 = area;
            float a = val5(6);
            Console.WriteLine("Area: " + a); 


            
        }
    }
}
