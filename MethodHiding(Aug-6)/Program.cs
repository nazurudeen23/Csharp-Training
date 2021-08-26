using System;

namespace MethodHiding_Aug_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass Base = new BaseClass();
            Base.Writestr();
            Base.Writenum();

            BaseClass DrivedBase = new DrivedClass();
            DrivedBase.Writestr();
            DrivedBase.Writenum();

            DrivedClass Drived = new DrivedClass();
            Drived.Writestr();
            Drived.Writenum();
        }
    }
}
