using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Salesperson : Employee
    {
        public Salesperson() { }
        public Salesperson(string fullName, int age, int empID,
                        float currPay, string ssn, int numbOfSales)
            :base(fullName, age, empID, currPay, ssn)
        {
           SalesNumber = numbOfSales;
        }
        public int SalesNumber { get; set; }
    }
}
