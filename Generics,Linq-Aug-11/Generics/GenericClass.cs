using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericList<k, v>
    {
        Dictionary<k,v> val = new Dictionary<k,v>();

        public void Add(k key, v value) => val.Add(key, value);//ADD
        public void Remove(k key) => val.Remove(key);//REMOVE
        public void sort()//SORT
        {
            var list = val.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine(key);

            }
            Console.WriteLine();
        }

       
        public void print()
        {
            foreach (var item in val)
            {
                Console.WriteLine($"Key:{item.Key}  Value:{item.Value}");
            }
        }
    }
}