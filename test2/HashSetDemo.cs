using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adv.test2
{/* WAP to add user define  objects  of type of employee  in a hashset employee object make sure 
   if i create 2 differt  object with same data  the other one should be added  as hashset stored unic objects*/


    public class Empl
    {
        int id;
        string name;
        Empl()
        {

        }
        public Empl(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

      /*  public int Id
        {
            set
            {
                value = id;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set { value = name; }
            get { return name; }
        }

*/
        public override string ToString()
        {
            return " id:" + id + "  name: " + name;
        }


    }
    class HashSetDemo
    {
        public static void Main(string[] args)
        {
            HashSet<Empl> myhashset = new HashSet<Empl>();
            myhashset.Add(new Empl(121, "Archana"));
            myhashset.Add(new Empl(122, "Rima"));
            myhashset.Add(new Empl(123, "shriya"));
            myhashset.Add(new Empl(124, "shree"));
            myhashset.Add(new Empl(124, "shree"));

            foreach (var l in myhashset)
                Console.WriteLine(l);
            

        }
    }
}
