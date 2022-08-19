using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv.test2
{
    class DictionaryDemo
    {
/* WAP  to create  a dictonary  where  key is of string and type  value of float type and print all key value pairs*/
        public static void Main(string[] args)
        {
            Dictionary<string, float> mydictionary = new Dictionary<string, float>();
            mydictionary.Add("archana", 45.5f);
            mydictionary.Add("Archana", 64.6f);
            mydictionary.Add("puja", 67.5f);
            mydictionary.Add("meera", 45.00f);
            mydictionary.Add("aaisha",12.6f);
            mydictionary.Add("aarya", 66.66f);
            foreach (var m in mydictionary)
                Console.WriteLine(m);

        }
    }
}
