using System;
using System.Text.RegularExpressions;


namespace Constructors
{
    class DematAccount : SalaryAccount
    {
        private string panCardNum;

        public DematAccount(string Accountnum, string Name, double Balance, string pancardnum) : base(Accountnum, Name, Balance)
        {
            this.panCardNum = pancardnum;
        }
        public string validatePan()
        {
            Regex regex = new Regex(@"[A-Z]{5}[0-9]{4}[A-Z]{1}");
            return regex.IsMatch(panCardNum) ? "Valid" : "Not valid";
        }
        public void getSalaryWithDemat()
        {
            base.getSalary();
            Console.WriteLine("Your PAN ID is: {0}", validatePan());
        }
    }
}
