using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я загадал вам число от 1 до 100\nЧто это за число?");
            Random random = new Random();
            int countOfAttempts = 0,playerNum = 0,randomNum = random.Next(1,100);
            while (playerNum!=randomNum) 
            {
                playerNum = Convert.ToInt32(Console.ReadLine());
                if (playerNum > randomNum)
                {
                    countOfAttempts++;
                    Console.WriteLine("Ваше число больше загаданного");
                    continue;
                }
                else if (playerNum < randomNum)
                {
                    countOfAttempts++;
                    Console.WriteLine("Ваше число меньше загаданного");
                    continue;
                }
                else 
                {
                    countOfAttempts++;
                    Console.WriteLine("Поздравляем! Вы победили! Количество попыток - {0}",countOfAttempts);
                }
            }
            Console.ReadKey();
        }
    }
}
