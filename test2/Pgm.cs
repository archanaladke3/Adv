using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adv.test2
{
/*
 wAP  to create a sortedList<Employee ,string> where key is of employee type and value is dept name;
he works in.sortedList should Maintain decending order 
 */



    public class Employee : IComparable
    {
        int id;
        string name;

       public  Employee()
        {

        }
        public   Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        /* public override bool Equals(object obj)
         {
             return base.Equals(obj);
         }*/

        public override string ToString()
        {
            return "  id:" + id + "  name:" + name ;
        }

        int IComparable.CompareTo(object obj)
        {
            return 1;
        }
        



    }
    class Pgm
    {
        public static void Main(string[] args)

        {
            SortedList<Employee, string> mysortedlist = new SortedList<Employee, string>();
            mysortedlist.Add(new Employee(121, "Archana"), "IT");
            mysortedlist.Add(new Employee(122, "Raavi"), "entc");
            mysortedlist.Add(new Employee(123, "Aarya"), "testing");
            mysortedlist.Add(new Employee(124, "Riya"), "hr");
            mysortedlist.Add(new Employee(125, "Meera"), "account");
            mysortedlist.Add(new Employee(126, "Priya"), "IT");

            foreach (var a in mysortedlist)
                Console.WriteLine(a);

        }
        
    

       // mysortedlist.Add()
    }
}
