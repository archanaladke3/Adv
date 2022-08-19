using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test
{
/*WAP to print a linkedList in reverse order*/
    class ReverseOrder
    {
        public static void Main(string[] args)
        {
            LinkedList<string> l = new LinkedList<string>();
            l.AddFirst("Archana");
            l.AddFirst("priti");
            l.AddFirst("divya");
            l.AddFirst("pooja");
            l.AddLast("nishi");
              l.Reverse();
            foreach (var s in l)
              //  Console.WriteLine(s);
            
                Console.WriteLine(s);
            /*foreach (var t in l)
                Console.WriteLine(l.Reverse());*/
           
            
        }
    }
}
