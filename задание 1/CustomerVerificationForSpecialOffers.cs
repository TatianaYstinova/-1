using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public static class Library
    {
        public static string ReadName()
        {
            Console.WriteLine("Имя клиента");
            string name = Console.ReadLine();
            return name;
        }
        public static int ReadAge()
        {
            Console.WriteLine("Возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public static int ReadBankProductsAmount()
        {
            Console.WriteLine("Количество банковских продуктов");
            int bankProductsAmount = Convert.ToInt32(Console.ReadLine());
            return bankProductsAmount;
        }
        public static int ReadTotalMoney()
        { 
            Console.WriteLine("Суммы потраченных средств");
            int totalMoney = Convert.ToInt32(Console.ReadLine());
            return totalMoney;
        }
        public static bool AreOffersAvailable(int bankProductsAmount, int totalMoney, int age)
        {
            return age > 60 && ((totalMoney > 1000000) || (totalMoney > 400000 && bankProductsAmount >= 3));
        }
    }
}
