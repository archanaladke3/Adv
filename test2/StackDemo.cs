using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test2
{
/* make use of collection  that stores  movie name last enter movie is  first deleted  and accordingly previous one*/
    class StackDemo
    {
        public static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Endgame");
            s.Push("spiderman");
            s.Push("harry Potter");
            s.Push("URi");
            

            foreach (var a in s)
                Console.WriteLine(a);

          
        }
    }
}
