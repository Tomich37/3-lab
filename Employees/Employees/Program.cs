using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            PTSalesperson genry = new PTSalesperson("Genry", 19, 2, 16000, "652114", 0);
            genry.DisplayStats();
            genry.ReductionSalary();
            genry.DisplayStats();
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();
            Console.WriteLine("Benefits: {0}", cost);
            chucky.DisplayStats();
            Console.ReadLine();
        }
    }
}
