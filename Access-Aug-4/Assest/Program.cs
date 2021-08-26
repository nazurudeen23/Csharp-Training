using System;
using AssestClass;

namespace Assest
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer computer = new Computer();
            computer.configuration();
            computer.warranty();

            Laptop laptop = new Laptop();
            laptop.configuration();
            laptop.warranty();

            Headphone headphone = new Headphone();
            headphone.configuration();
            headphone.warranty();

            Mouse mouse = new Mouse();
            mouse.configuration();
            mouse.warranty();

            DockStation dock = new DockStation();
            dock.configuration();
            dock.warranty();
        }
    }
}