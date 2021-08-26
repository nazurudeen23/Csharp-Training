using System;

namespace ClassLibrary
{
    public static class Employee
    {
        public static int id;
        public static string name;
        public static string title;


       static Employee()
        {
            id = 11;
            name = "nazurudeen";
            title = "Devoloper";
        }
       
        public static void Info()
        {
            Console.WriteLine($"The employee {name} was getting {title} position.");
        }
        
    }
}