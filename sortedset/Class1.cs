using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Adv.sortedset
{

    class myStringBuilderSor/// : IComparer<StringBuilder>
    {
        public int Cmpare(StringBuilder x, StringBuilder y)
        {
            return ToString().CompareTo(y.ToString());
        }
    class Class1
    {
        public static void Main(string[] args)
        {
           // SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
        }
    }
}}

