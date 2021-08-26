using System;

namespace Constructors
{
    public class SalaryAccount
    {

        private string Accountnum;
        private string Name;
        private double Balance;

        public SalaryAccount(string Accountnum, string Name, double Balance)
        {
            this.Accountnum = Accountnum;
            this.Name = Name;
            this.Balance = Balance;
        }

        public void getSalary()
        {
            Console.WriteLine($"your salary account detail...\nAcc No: {Accountnum}\nName:{Name}\nBalance:{Balance}");
        }


    }
}
