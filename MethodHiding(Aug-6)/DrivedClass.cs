using System;


namespace MethodHiding_Aug_6_
{
    class DrivedClass : BaseClass
    {
        public new int num = 2000;
        public new void Writenum()
        {
            Console.WriteLine("This is drived int value " + num);
        }

        public override void Writestr()
        {
            base.Writestr();
        }
    }
}
