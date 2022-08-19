using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test2
{
/* WAP to create SortedList where key is of integer  type  and value string tpype  and print all key- value pair
 */
    class SortedListDemo
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> mylist = new SortedList<int, string>();

            mylist.Add(121, "Archana");
            mylist.Add(122, "Aaisha");
            mylist.Add(124, "Meera");
            mylist.Add(123, "Divya");
            mylist.Add(101, "Archana");
            mylist.Add(500, "riya");
            foreach (var list in mylist)
                Console.WriteLine(list);


        }
       

    }
}
