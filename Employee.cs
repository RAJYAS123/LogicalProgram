using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    [Serializable]
    public class Employee
    {
        public int Id;
        public string Name;
        private string employeename;
        public string EmployeeName
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }

        public Employee(int Id ,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
