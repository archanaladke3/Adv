using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.DemoCollections
{
    class Class1
    {
        public static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(200);
            ll.AddFirst(100);
            ll.AddFirst(300);
            // lq.Clear();
            Console.WriteLine("Linlkedlist element COUNT is:" + ll.Count);
            Console.WriteLine("LinqList element Are:");
            foreach (int var in ll)
                Console.WriteLine(var);
            Console.WriteLine("**************************");


            LinkedList<string> car = new LinkedList<string>();
            car.AddLast("ODDII");
            car.AddLast("BMW");
            car.AddLast("RANGE ROVER");
            car.AddLast("Mercedes");
            car.AddLast("FORTUNER");
            car.AddLast("JAGUAR");
            car.AddLast("LEXUS");
            car.AddLast("VOLVO");

            car.AddFirst("PORSCHE");
            foreach (string c in car)
                Console.WriteLine(c);
            LinkedListNode<string> nn = car.Find("VOLVO"); // finding the node 
            car.AddAfter(nn, "HONDA_CITY"); // added the value after finding the nodes and add before and after the vallue
            car.AddBefore(nn, "BALENO");

            LinkedListNode<string> fst = car.First; // display first element of the linqedlist
            Console.WriteLine("My first car: " + fst.Value);
            LinkedListNode<string> lst = car.Last;
            Console.WriteLine("My last car: " + lst.Value);


            Console.WriteLine("Is BMW in LINKEDLIST: " + car.Contains("BMW"));
            Console.WriteLine("Linlkedlist car COUNT is:" + car.Count);


            // car.RemoveFirst();// remove first eleemnt from likedlist
            // car.Remove("BMW");// remove specific element from likedlist

            Console.WriteLine("The Cars in LinkedList are:");
            foreach (string var in car)
                Console.WriteLine(var);

        }
    }
}
