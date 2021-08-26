using ClassLibrary;
using ClassLibrary2;
using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager();
            mg.SetName("nasur");
            mg.SetId(101);


            Console.WriteLine();
            Console.WriteLine("*******EMPLOYEE INFO*******");
            Console.WriteLine();
            Console.WriteLine("Employee name is "+Employee.name);
            Console.WriteLine($"employee id number is {Employee.id}");
            Console.WriteLine("Job title is " + Employee.title);
            Employee.Info();
            Console.WriteLine();

            Console.WriteLine("*******MANAGER INFO*******");
            Console.WriteLine();
            Manager.ManagerInfo();
            Console.WriteLine("manager name is "+mg.GetName());
            Console.WriteLine("manager id is "+mg.GetId());

        }
    }
}
