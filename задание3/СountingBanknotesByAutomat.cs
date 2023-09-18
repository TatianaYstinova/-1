using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание3
{
    public static class СountingBanknotesByAutomat
    {
        public static int AmountRequested()
        {
            Console.WriteLine("Введите сумму денег ");
            int money = Convert.ToInt32(Console.ReadLine());
            return money;
        }
        public static int OptimalNumberBanknotes(int money)
        {
            int rublThousand = 0;
            int rublFiveHndred = 0;
            int rublOneHundred = 0;
            if(money < 0) 
            {
                throw new ArgumentException("money < 0 tak nelzia");
            }

            while (money >= 1000)
            {
                money = money - 1000;
                rublThousand++;
            }
            while (money >= 500)
            {
                money = money - 500;
                rublFiveHndred++;
            }
            while (money >= 100)
            {
                money = money - 100;
                rublOneHundred++;
            }
            
            return rublThousand + rublFiveHndred + rublOneHundred;
        }
    }
}
