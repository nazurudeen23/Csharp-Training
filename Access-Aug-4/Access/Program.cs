using System;
using Car;

namespace Access
{
    class Program
    {
        static void Main(string[] args)
        {
            CarName cn = new CarName();
            cn.SetYearOfRelease("2014");
            Console.WriteLine("Car Releasing Year : " + cn.GetYearOfRelease());
            cn.carname = "audi";
            cn.SetModel("audi 3");
            cn.print();
            Console.ReadKey();

        }
    }
}

