using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент а:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискриминант равен {0}",discriminant);
            if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (discriminant == 0)
            {
                double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("У нас всего один корень: {0}", x);
            }
            else 
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Первый корень: {0:f3}\nВторой корень: {1}",x1,x2);
            }
            Console.ReadKey();
        }
    }
}
