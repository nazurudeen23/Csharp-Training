using System;

namespace Car
{
    public class CarName
    {
        public string carname;

        private string model;

        protected string yearOfRelease;
        public string GetModel()
        {
            return model;
        }

        public void SetModel(string m)
        {
            model = m;
        }

        public string GetYearOfRelease()
        {
            return yearOfRelease;
        }
        public void SetYearOfRelease(string YearOfRelease)
        {
            yearOfRelease = YearOfRelease;
        }

        internal static void CostomerDetails()
        {
            Console.WriteLine("customer details");
        }
        public void print()
        {
            Console.WriteLine("Car Name : " + this.carname);
            Console.WriteLine("Model : " + this.model);
        }
    }
}
