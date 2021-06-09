using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        public static int GetMaxString(string x) 
        {
            int maxString = 0,newString = 1;
            char firstLetter = x[0];
            char newFirstLetter = char.ToLower(firstLetter);
            for (int i = 1;i<x.Length;++i) 
            {
                char secondLetter = x[i];
                char newSecondLetter = char.ToLower(secondLetter);
                if (newFirstLetter == newSecondLetter)
                {
                    newString++;
                    maxString = newString;
                }
                else if (newFirstLetter != newSecondLetter) 
                {
                    newFirstLetter = newSecondLetter;
                    if (newString>maxString) 
                    {
                        maxString = newString;
                    }           
                    newString = 1;
                    continue;
                }
            }
            return maxString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxString("аааБбдеггГгв"));
            Console.ReadKey();
        }
    }
}
