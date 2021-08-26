using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankBranch> bankbranchesList = new List<BankBranch>();

            bankbranchesList.Add(new BankBranch { BankName = "State Bank", Location = "Chennai" });
            bankbranchesList.Add(new BankBranch { BankName = "HDFC", Location = "Banglore" });
            bankbranchesList.Add(new BankBranch { BankName = "Axis Bank", Location = "Hyderabad" });
            

            List<BankManager> bankmanagersList = new List<BankManager>();

            bankmanagersList.Add(new BankManager { ManagerName = "Max", BankName = "State Bank", Age = 32, MaxPoint = 100 });
            bankmanagersList.Add(new BankManager { ManagerName = "Joe", BankName = "HDFC", Age = 31, MaxPoint = 120 });
            bankmanagersList.Add(new BankManager { ManagerName = "Phill", BankName = "Axis Bank", Age = 29, MaxPoint = 110 });

            //1.display the branches and respective managers
            foreach (BankManager manager in bankmanagersList)
            {
                Console.WriteLine($"{manager.BankName} brach manager is {manager.ManagerName}");
            }
            Console.WriteLine();

            //2. Display list of managers who are aged above 30  along with the branch name  
            var bankmanagersAbove30 = bankmanagersList.FindAll(x => x.Age > 30);

            foreach (var age in bankmanagersAbove30)
            {
                Console.WriteLine("The managers name whose age is about 30: " + age.ManagerName);
            }

            Console.WriteLine();

            //3. Display the manager who has earned maximum points (create a property called maxpoint in branches)
            var max_point = bankmanagersList.Max(point => point.MaxPoint);

            var bankmanagersMaxPoint = bankmanagersList.FindAll(x => x.MaxPoint == max_point);

            foreach (var maxpoint in bankmanagersMaxPoint)
            {
                Console.WriteLine("The bank manager who has maximum point: " + maxpoint.ManagerName);
            }




        }
    }
}
