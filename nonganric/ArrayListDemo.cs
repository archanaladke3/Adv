using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.nonganric
{


    class SS<T>
    {
        private T obj;

        public T Obj
        {
            get => obj;
            set => obj = value;
        }

    }
    class S
    {
        private Object obj;
        public Object Obj
        {
            get => obj;
            set => obj = value;

        }
    }
      
    class ArrayListDemo
    {
        public static void Main()
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;
            S s = new S();
            s.Obj = "omkar";
            s.Obj = 9000;
            int x=(int)s.Obj;

        }
        
    }
}
