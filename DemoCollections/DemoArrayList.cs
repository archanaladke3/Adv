using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.DemoCollections
{
    class DemoArrayList
    {
        public static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(123);
            arlist.Add("Archana");
            arlist.Add(4657.8747f);
            arlist.Add(42562.87d);

            foreach (var al in arlist)
                Console.WriteLine(al);

        }
    }
    public class DemoListArray
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            { 1,"Archana","puja",3456,null,233,45};
            al.Insert(2, "inserted element");
            foreach (var list in al)
                
            Console.WriteLine(list);
            al.RemoveAt(1);
            // al.RemoveAt();

        }
    }
     public class InsertSizeOfArray
    {
        public static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(100);
            a.Add(200);
            a.Add(300);
            ArrayList al = new ArrayList();
            al.Add(400);
            al.Add(500);
            al.Add(600);
/*insert rang we can merge two arraylist*/
            a.InsertRange(3,al);
            foreach (var aa in a)
                Console.WriteLine(aa);
        }
    }

  public class DemoSortedList
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> al = new SortedList<int, string>();
            al.Add(1, "Archana");
            al.Add(2, "priti");
            al.Add(3, "seema");
            al.Add(4, "priya");
            foreach (var a in al)
                Console.WriteLine(a);

        }
    }
    public class Demostack
    {
        public static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(6);
            mystack.Push(78);
            mystack.Push(78);
            Console.WriteLine("count of elements:"+mystack.Count);
            Console.WriteLine("pop method:"+mystack.Pop());
            Console.WriteLine("after delete element in stack:" + mystack.Count);
             
        
           
            foreach (var st in mystack)
                Console.WriteLine(st);
        }
    }
    class Stack 
    { 
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            
        }
    }
}
