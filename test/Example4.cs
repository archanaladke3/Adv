using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test
{/*WAP to create list of student and iterate over it*/
    class Example4
    {
        public static void Main(string[] args)
        {
            LinkedList<string> stud = new LinkedList<string>();
            stud.AddFirst("student1");
            stud.AddFirst("student2");
            stud.AddFirst("student3");
            stud.AddFirst("student4");
            foreach (var student in stud)
                Console.WriteLine(student+"\n");

        }
    }
}
