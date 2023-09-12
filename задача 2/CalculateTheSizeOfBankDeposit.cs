using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2
{
    public static class CalculateЕTheSizeOfBankDeposit
    {
        public static int ReadSum()
        {
           Console.WriteLine(" Введите изначальную сумму");
           int sum = Convert.ToInt32(Console.ReadLine());
           return sum;
        }
        public static int ReadDurationYears() 
        {
            Console.WriteLine("Введите продолжительность в годах");
            int durationYears = Convert.ToInt32(Console.ReadLine());
            return durationYears;
        }
        public static int ReadPercent() 
        {
            Console.WriteLine("Введите процент начисляемый за год");
            int percent = Convert.ToInt32(Console.ReadLine());
            return percent;
        }
        public static int AmountOfSavings(int durationYears, int sum, int percent) 
        {
            for (int i = 1; i <= durationYears; i++)
            {
                sum += sum * percent / 100;
            }
            return sum;
        }
    }
}
