using System;


namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryAccount salary = new SalaryAccount("3256788364", "nazurudeen",1000);
            salary.getSalary();
            Console.WriteLine();

            DematAccount demat = new DematAccount("4445127572", "mohamed", 7000,"FRTEQ2993E");
            demat.getSalaryWithDemat();
        }
    }
}
