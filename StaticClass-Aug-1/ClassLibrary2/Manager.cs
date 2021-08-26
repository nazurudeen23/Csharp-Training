using System;

namespace ClassLibrary2
{
    public class Manager
    {
        public int id;
        public string name;

        public void SetId(int Id)
        {
            id = Id;
        }
        
        public int GetId()
        {
            return id;
        }
        public void SetName(string Name)
        {
            name = Name;
        }

        public string GetName()
        {
            return name;
        }

        public static void ManagerInfo()
        {
            Console.WriteLine($"manager info is here...");
        } 
        
    }
}
