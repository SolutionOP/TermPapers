using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент годовых:");
            double percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев:");
            double countOfMonth = Convert.ToDouble(Console.ReadLine());
            double newPercent = percent/12;
            double newSum = sum + ((sum / 100) * newPercent);
            for (int i = 1;i <countOfMonth;i++) 
            {
                    newSum +=(newSum /100)*newPercent;
            }
            Console.WriteLine("Сумма вклада по окончанию {0} месяцев будет равна {1:f3}",countOfMonth,newSum);
            Console.WriteLine("Прибыль будет равна {0:f3}",newSum - sum);
            Console.ReadKey();
        }
    }
}
