using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.DemoCollections
{
    class HashDemo
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Archana", 90);
            dd.Add("Aarti", 78);
            dd.Add("priti", 70);
            ICollection<string> cc = dd.Keys;
            foreach (string k in cc)
                Console.WriteLine(k);
        }
    }
}
