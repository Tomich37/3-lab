using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            // Создать счет
            SavingsAccount s1 = new SavingsAccount(50);
            // Вывести текущую процентную ставку
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Попытка изменения проц ставки через свойство
            SavingsAccount.SetInterestRate(0.04);
            //Создание второго счета
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
