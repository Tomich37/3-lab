using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    // Простой класс депозиторного счета
    class SavingsAccount
    {
        // Данные уровня экземпляра
        public double currBalance;
        // Статический элемент данных
        public static double currInterestRate;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
 
        // Статические члены для установки/получения процентной ставки
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }

        public static double GetInterestRate(double newRate)
        {
            return currInterestRate;
        }

        // Статический конструктор
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.12;
        }
    }
}
