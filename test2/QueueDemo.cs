using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test2
{
/* WAP to create a queue  with some color<string> using generics*/
    class QueueDemo
    {

        public static void Main(string[] args)
        {
            Queue<string> color = new Queue<string>();
            color.Enqueue("red");
            color.Enqueue("blue");
            color.Enqueue("pink");
            color.Enqueue("black");
            color.Enqueue("white");
            foreach (var clr in color)
                Console.WriteLine(clr);

        }
    }
}
