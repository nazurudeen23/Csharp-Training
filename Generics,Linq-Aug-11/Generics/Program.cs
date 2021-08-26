using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int, string> genericlist = new GenericList<int, string>();
            genericlist.Add(1, "IRONMAN");
            genericlist.Add(2, "THOR");
            genericlist.Add(5, "CAPTAIN AMERICA");
            genericlist.Remove(2);
            genericlist.sort();
            genericlist.print();
        }
    }
}
