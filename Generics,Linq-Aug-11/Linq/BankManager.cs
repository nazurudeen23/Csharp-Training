using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class BankManager
    {
        private string _managerName;
        private int _age;
        private int _maxPoint;
        private string _bankName;

        public string ManagerName { get => _managerName; set => _managerName = value; }
        public int Age { get => _age; set => _age = value; }
        public int MaxPoint { get => _maxPoint; set => _maxPoint = value; }
        public string BankName { get => _bankName; set => _bankName = value; }

       
    }
}
