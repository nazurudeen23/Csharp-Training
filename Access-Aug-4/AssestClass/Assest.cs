using System;

namespace AssestClass
{
    public abstract class Assest
    {
        public abstract void configuration();

        public void warranty()
        {
            Console.WriteLine("Two years warranty available for every product");
        }
    }

    public class Computer : Assest
    {
        public override void configuration()
        {
            Console.WriteLine("Computer have 1Tb storage facility");
        }
    }

    public class Laptop : Assest
    {
        public override void configuration()
        {
            Console.WriteLine("Laptop have touch screen facility");
        }
    }

    public class Headphone : Assest
    {
        public override void configuration()
        {
            Console.WriteLine("Noice cancelation facilities");
        }
    }

    public class Mouse : Assest
    {
        public override void configuration()
        {
            Console.WriteLine("12 Hour battery facilities");
        }
    }

    public class DockStation : Assest
    {
        public override void configuration()
        {
            Console.WriteLine("Dockstation Configuration");
        }
    }
}