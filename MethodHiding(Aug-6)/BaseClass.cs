using System;


namespace MethodHiding_Aug_6_
{
    class BaseClass
    {
        public int num = 10;
        public string str = "This is base class string";

        public void Writenum()
        {
            Console.WriteLine("Thos is base class int value " + num);
        }

        public virtual void Writestr()
        {
            Console.WriteLine(str);
        }
    }
}
