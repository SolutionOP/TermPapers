using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evklid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int result = firstNum;
            while (firstNum != secondNum) 
            {
                if (firstNum > secondNum)
                {
                    firstNum -= secondNum;
                    result = firstNum;
                }
                else 
                {
                    secondNum -= firstNum;
                    result = secondNum;
                }
            }
            Console.WriteLine("Наибольший общий делитель равен {0}",result);
            Console.ReadKey();
        }
    }
}
