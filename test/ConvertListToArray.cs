using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test
{
    class ConvertListToArray
    {
        public static void Main(string[] args)
        {
            LinkedList<string> al = new LinkedList<string>();
            al.AddFirst("vivo");
            al.AddFirst("redmi");
            al.AddFirst("oppo");
            al.AddFirst("nokia");
            al.AddFirst("samsung");
            al.AddFirst("asus");
            string[] a = al.ToArray();
            foreach (var mob in a)
                Console.WriteLine(mob);     

        }
    }
}
