using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.DemoCollections
{



    public  class Emp
    {
        int empno;
        string ename;
        string deptname;
        Emp()
        {

        }
       public  Emp(int empno, string ename,string deptname)
        {
            this.empno=empno;
            this.ename = ename;
            this.deptname = deptname;
        }
        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }

        }
        public string Deptname
        {
            set { deptname=value; }
            get { return deptname; }
        }
        public override string ToString()
        {
            return "empno:" + empno + "ename:" + ename+"Deptname:"+deptname;
        }

    }
    class LinkedListDemo
    {
        public static void Main(string[] args)
        {
            LinkedList<Emp> ll = new LinkedList<Emp>();
             ll.AddFirst(new Emp(11, "Archana", "Cs"));
            ll.AddLast(new Emp(12, "divya", "IT"));
            ll.AddLast(new Emp(13, "priya", "cs"));
            ll.AddLast(new Emp(14, "nisha", "EE"));
            foreach (Emp e in ll)
                Console.WriteLine(e);
        }
      
    }


 }
