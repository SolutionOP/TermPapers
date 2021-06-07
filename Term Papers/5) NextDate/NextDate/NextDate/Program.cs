using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сегодняшний день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сегодняшний месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сегодняшний год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool leap = false;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                leap = true;
            }

            int nextDay = day + 1;
            int nextMonth = month;
            int nextYear = year;

            if (month == 2 && (leap && nextDay == 30 || !leap && nextDay == 29))
            {
                nextDay = 1;
                nextMonth = 3;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && nextDay == 31)
            {
                nextDay = 1;
                nextMonth++;
            }
            else if (nextDay == 32)
            {
                nextDay = 1;
                if (++nextMonth == 13)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            Console.WriteLine("Следующий день - {0}\nСледующий месяц - {1}\nСледующий год - {2}",nextDay,nextMonth,nextYear);
            Console.ReadKey();
        }
    }
}
