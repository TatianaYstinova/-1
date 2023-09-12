using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание3
{
    internal class СountingBanknotesByAutomat
    {
        public static int AmountRequested()
        {
            Console.WriteLine("Введите сумму денег ");
            int money = Convert.ToInt32(Console.ReadLine());
            return money;
        }
        public static int OptimalNumberBanknotes(int money)
        {
            int rubl1000 = 0;
            int rubl500 = 0;
            int rubl100 = 0;

            while (money >= 1000)
            {
                money = money - 1000;
                rubl1000++;
            }
            while (money >= 500)
            {
                money = money - 500;
                rubl500++;
            }
            while (money >= 100)
            {
                money = money - 100;
                rubl100++;
            }
            
            return rubl1000 + rubl500 + rubl100;
        }
    }
}
