using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test2
{/*WAP to sort the element of list that conatains string object of list*/

    public  class Emp
    {
        string name;
        string designation;
        long salary;

        Emp()
        {

        }
       public  Emp(string name,string designation,long salary)
        {
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }
        public string Name
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;

        }
        public long Salary
        {
            set{ salary = value; }
            get { return salary; }
        }
        public override string ToString()
        {
            return "  name:" + name + "  designation:" + designation + "  salary:" + salary;
        }


    }
    class ListDemo
    {
        public static void Main(string[] args)
        {
            List < Emp >emp = new List<Emp>();
            emp.Add(new Emp( "riya","devop",25558));
            emp.Add(new Emp("siya", "testing", 46755));
            emp.Add(new Emp("Ram", "accounting", 67544));
            emp.Add(new Emp("Ram", "testing", 86855));
            foreach (var e in emp) 
            Console.WriteLine(e);
        }

    }
}
