using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите степень числа,которое будем возвращать:");
            int n = Convert.ToInt32(Console.ReadLine());
            int f, f1 = 0, f2 = 1;
            switch (n) 
            {
                case 0:
                    f = 0;
                    Console.WriteLine("Число Фибоначи в степени {0} равно {1}", n, f);
                    break;
                case 1:
                    f = 1;
                    Console.WriteLine("Число Фибоначи в степени {0} равно {1}", n, f);
                    break;
                default:
                    for (int i = 0; i < n; i++)
                    {
                        f = f1 + f2;
                        f1 = f2;
                        f2 = f;

                        while (i == n - 2)
                        {
                            Console.WriteLine("Число Фибоначи в степени {0} равно {1}",n,f);
                            break;
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
