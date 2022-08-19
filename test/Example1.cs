using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test
/* WAP add elements to list<string> insert at specifes=d postion, udpate and delete a elements*/
{
    class Example1
    {
        public static void Main(string[] args)
        {
            LinkedList<string> no = new LinkedList<string>();
            no.AddFirst("one");
            no.AddFirst("two");
            no.AddFirst("three");
            no.AddLast("four");
            no.AddFirst("five");
            no.AddLast("six");

            LinkedListNode<string> node = no.Find("five");
            no.AddAfter(node, "fifteen");
            no.AddBefore(node, "fourteen");
            foreach (string number in no)
                Console.WriteLine(number);
            Console.WriteLine(no.Contains("one"));


            no.Remove("two");
            no.RemoveFirst();
            no.RemoveLast();


           // Console.WriteLine("******reverse of linkedList:" + no.Reverse());
            

            Console.WriteLine("****after removing elemner");

            foreach (string number in no)
                Console.WriteLine(number);
            
          
        }
    }
}