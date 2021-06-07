using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите ваш возраст:");
                int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 1 && age <= 112)
            {
                if (age == 1 || (age % 10 == 1 && age > 20 && age < 110) || age == 101)
                {
                    Console.WriteLine("Вам {0} год", age);
                }
                else if ((age >= 2 && age <= 4) || ((age % 10 >= 2 && age % 10 <= 4) && age % 100 <= 104 && age % 100 > 15) || (age >= 102 && age <= 104))
                {
                    Console.WriteLine("Вам {0} года", age);
                }
                else
                {
                    Console.WriteLine("Вам {0} лет", age);
                }
            }
            else if (age < 1)
            {
                Console.WriteLine("Вы слишком малы");
            }
            else if (age > 112)
            {
                Console.WriteLine("Вы слишком стары");
            }
            Console.ReadKey();
        }
    }
}
