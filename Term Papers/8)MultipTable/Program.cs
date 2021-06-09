using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("От какого числа будет начинаться таблица?");
            int startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Каким числом будет заканчиваться таблица?");
            int finishNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("   ");
            for (int i = startNum;i<=finishNum;i++) 
            {
                Console.Write(i.ToString().PadLeft(5));
            }
            Console.WriteLine("\n".PadRight(finishNum/2+finishNum*5,'_'));
            for (int i = startNum;i<=finishNum;i++) 
            {
                Console.WriteLine("\n  |");
                for (int j = startNum;j<=finishNum;j++) 
                {
                    if ( j == startNum) 
                    {
                        if (i < 10)
                        {
                            Console.Write(i + " |");
                        }
                        else 
                        {
                            Console.Write(i + "|");
                        }       
                    }
                    Console.Write((i * j).ToString().PadLeft(5));

                }
            }
            Console.ReadKey();
        }
    }
}
