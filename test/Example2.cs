using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test
{
/*WAP  to create a new list add some colour (string)  print the collections*/
    class Example2
    {
        public static void Main(string[] args)
        {
            string[] color = { "red", "blue", "black", "white", "purple" };
            LinkedList<string> cl = new LinkedList<string>(color);
            foreach(string list in cl)
            Console.WriteLine(list);
        }

    }
}
