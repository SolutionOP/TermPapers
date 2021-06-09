using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово для проверки на палиндром:");
            string s = Console.ReadLine();
            bool isPalindrom = false;
            for (int i = 0;i<s.Length/2;++i) 
            {
                char firstS = char.ToLower(s[i]);
                char secondS = char.ToLower(s[s.Length - i - 1]);
                if (firstS == secondS)
                {
                    isPalindrom = true;
                }
                else 
                {
                    isPalindrom = false;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine("Ваше слово является палиндромом");
            }
            else 
            {
                Console.WriteLine("Ваше слово не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
