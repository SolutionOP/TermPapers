using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x точки A:");
            double xA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y точки A:");
            double yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x точки B:");
            double xB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y точки B:");
            double yB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x точки C:");
            double xC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y точки C:");
            double yC = Convert.ToDouble(Console.ReadLine());

            double lengthAB = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2));
            double lengthBC = Math.Sqrt(Math.Pow((xC - xB), 2) + Math.Pow((yC - yB), 2));
            double lengthCA = Math.Sqrt(Math.Pow((xA - xC), 2) + Math.Pow((yA - yC), 2));

            double p = (lengthAB + lengthBC + lengthCA)/2;

            double triangleAcreage = Math.Sqrt(p*(p - lengthAB)*(p - lengthBC)*(p - lengthCA));

            if ((xA == xB && xB == xC) || (yA == yB && yB == yC))
            {
                Console.WriteLine("Все ваши точки лежат на одной плоскости");
            }
            else 
            {
                Console.WriteLine("Площадь треугольника равна {0}",triangleAcreage);
            }           
            Console.ReadKey();
        }
    }
}
